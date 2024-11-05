using Memory;
using MetroSet_UI.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Timers;
using Sunny.UI;
using Timer = System.Timers.Timer;
using NHotkey;
using NHotkey.WindowsForms;
using System.Collections.Generic;

namespace Helium
{


    public partial class HeliumForm : MetroSetForm
    {
        public Mem m = new Mem();
        private System.Timers.Timer processCheckTimer;
        private readonly Dictionary<String, int> _hotkeyMap;
        private readonly Dictionary<int, ToggleAction> _scriptActions;
        public delegate void ToggleAction();



        public HeliumForm()
        {
            InitializeComponent();

            _hotkeyMap = new Dictionary<string, int>
            {
                { "F1", 1 },
                { "F2", 2 },
                { "F3", 3 },
                { "F4", 4 },
                { "F5", 5 },
            };

            _scriptActions = new Dictionary<int, ToggleAction>
            {
                    { 1, () => NoDropAnimationSwitch.Switched = !NoDropAnimationSwitch.Switched },
                    { 2, () => NoBobbingSwitch.Switched = !NoBobbingSwitch.Switched },
                    { 3, () => NoRenderItemsSwitch.Switched = !NoRenderItemsSwitch.Switched },
                    { 4, () => HideNamesSwitch.Switched = !HideNamesSwitch.Switched },
                    { 5, () => enableALL.Checked = !enableALL.Checked }
            };

            foreach (var kvp in _hotkeyMap)
            {
                HotkeyManager.Current.AddOrReplace(kvp.Key, (Keys)Enum.Parse(typeof(Keys), kvp.Key), HotKeyshandler);
            }

            // Some color overrides since the TabControl seems to be bugged and sets by default the ForeColor to Black even when the default color has been changed.
            enableALL.ForeColor = Color.White;
            Hispano.ForeColor = Color.Gray;
            proID.ForeColor = Color.White;
            Status.ForeColor = Color.White;
            NoDropLabel.ForeColor = Color.White;
            NoBobbingLabel.ForeColor = Color.White;
            NoRenderLabel.ForeColor = Color.White;
            NoFogRenderLabel.ForeColor = Color.White;
            HideNamesLabel.ForeColor = Color.White;
            HotKeysInfo.ForeColor = Color.White;

        }

        private void HotKeyshandler(object sender, HotkeyEventArgs e)
        {
            if (_hotkeyMap.TryGetValue(e.Name, out int scriptNumber))
            {
                ScriptHandler(scriptNumber);
            }
            e.Handled = true;
        }

        private void ScriptHandler(int scriptNumber)
        {
            if (_scriptActions.TryGetValue(scriptNumber, out ToggleAction action))
            {
                action();
            }
        }

        private void InfoClick(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This option will reset itself/be bugged when changing between realms/rooms/overworlds. Please uncheck and check it again to reapply the effect.",
                "Information", 
                MessageBoxButtons.OK,    
                MessageBoxIcon.Warning 
                
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartProcessCheckTimer();

            if (!HeliumWorker.IsBusy)
                HeliumWorker.RunWorkerAsync();
        }

        private void StartProcessCheckTimer()
        {
            processCheckTimer = new System.Timers.Timer(1000);
            processCheckTimer.Elapsed += ProcessCheckTimer_Elapsed;
            processCheckTimer.AutoReset = true;
            processCheckTimer.Enabled = true;
        }

        private void ProcessCheckTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            int pID = m.GetProcIdFromName("Cubic");
            bool openProc = false;
            if (pID > 0)
            {
                openProc = m.OpenProcess(pID);
                UpdateLabel(procIDLabel, pID.ToString(), Color.Green);
                
            }
            else
            {
                UpdateLabel(procIDLabel, "DISCONNECTED", Color.Red);
            }

            if (!openProc)
            {
                UpdateLabel(getStatus, "DISCONNECTED", Color.Red);
            }
            else
            {
                UpdateLabel(getStatus, "CONNECTED", Color.Green);
            }
        }

        private void UpdateLabel(Label label, string text, Color color)
        {

            if (label.InvokeRequired)
            {
                label.Invoke((MethodInvoker)delegate
                {
                    label.Text = text;
                    label.ForeColor = color;
                });
            }
            else
            {
                label.Text = text;
                label.ForeColor = color;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (processCheckTimer != null)
            {
                processCheckTimer.Stop();
                processCheckTimer.Dispose();
            }

            base.OnFormClosing(e);

            HotkeyManager.Current.Remove("F1");
            HotkeyManager.Current.Remove("F2");
            HotkeyManager.Current.Remove("F3");
            HotkeyManager.Current.Remove("F4");
            HotkeyManager.Current.Remove("F5");
            HotkeyManager.Current.Remove("F6");
            base.OnFormClosing(e);
        }

        private void EnableALL_CheckedChanged(object sender)
        {
            bool isEnabled = enableALL.Checked;

            NoRenderItemsSwitch.Switched = isEnabled;
            NoBobbingSwitch.Switched = isEnabled;
            NoDropAnimationSwitch.Switched = isEnabled;
            ViewDistanceSlider.Value = 100;
            HideNamesSwitch.Switched = isEnabled;
        }


        // From this point to the bottom is the main mod menu code

        private bool noRenderItemsState = false;
        private bool noDropAnimationState = false;
        private int viewDistanceSlider = 50;
        private bool noBobbingState = false;
        private bool noNameState = false;

        private Timer _updateTimer;

        private void HeliumWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            _updateTimer = new Timer(100);
            _updateTimer.Elapsed += UpdateMemoryOnTimerTick;
            _updateTimer.AutoReset = true;
            _updateTimer.Start();
        }

        private void UpdateMemoryOnTimerTick(object sender, ElapsedEventArgs e)
        {
            CheckAndUpdateMemory();
        }

        private void CheckAndUpdateMemory()
        {
            if (NoRenderItemsSwitch.Switched != noRenderItemsState)
            {
                noRenderItemsState = NoRenderItemsSwitch.Switched;
                if (noRenderItemsState)
                {
                    m.WriteMemory("Cubic.exe+1A9A74", "bytes", "EB 03 90 90 90");
                }
                else
                {
                    m.WriteMemory("Cubic.exe+1A9A74", "bytes", "E8 FC AB FE FF");
                }
            }

            if (NoDropAnimationSwitch.Switched != noDropAnimationState)
            {
                noDropAnimationState = NoDropAnimationSwitch.Switched;
                if (noDropAnimationState)
                {
                    m.WriteMemory("Cubic.exe+1A9A6B", "byte", "E1");              
                }
                else
                {
                    
                    m.WriteMemory("Cubic.exe+1A9A6B", "byte", "E0");
                }
            }

            if (ViewDistanceSlider.Value != viewDistanceSlider)
            {
                // Some normalizing math to make the value from 0 to 251 and properly proportional 
                int normalized_value = Convert.ToInt32(Math.Pow(ViewDistanceSlider.Value, 1.2));
                string hexCode = normalized_value.ToString("x2");
                viewDistanceSlider = ViewDistanceSlider.Value;
                m.WriteMemory("Cubic.exe+2F6F98", "byte", hexCode);
 
            }


            if (NoBobbingSwitch.Switched != noBobbingState)
            {
                noBobbingState = NoBobbingSwitch.Switched;
                if (noBobbingState)
                {
                    m.WriteMemory("Cubic.exe+1A9917", "bytes", "90 90 90 90 90 90 90 90");
                    m.WriteMemory("Cubic.exe+1A992F", "bytes", "90 90 90 90");
                }
                else
                {
                    m.WriteMemory("Cubic.exe+1A9917", "bytes", "F3 0F 58 05 2C 0D 5D 00");
                    m.WriteMemory("Cubic.exe+1A992F", "bytes", "F3 0F 58 C1");
                }
            }

            if (HideNamesSwitch.Switched != noNameState)
            {
                noNameState = HideNamesSwitch.Switched;
                if (noNameState)
                {
                    m.WriteMemory("Cubic.exe+1A6F1B", "byte", "01");
                }
                else
                {
                    m.WriteMemory("Cubic.exe+1A6F1B", "byte", "00");
                }
            }

            
        }

        private void metroSetTextBox1_Click(object sender, EventArgs e)
        {

        }
    }

}

