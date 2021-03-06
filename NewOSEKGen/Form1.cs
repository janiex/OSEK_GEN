using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO; 
using System.Reflection;



using System.Data;

namespace NewOSEKGen
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class OSEKForm : System.Windows.Forms.Form
	{
        private int MagicNumber;
        private int CountersForTimer_A;
        private int CountersForTimer_B;
        private int AutoStartAlarmCounter;
        private int AutostartTaskCounter;
        private OS OS_FORM;
        private const string NameOfSystem = "Kristian\'s OS";


    	private System.Windows.Forms.TreeView OStree;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.ContextMenu MyContext;
		// Counter Property
        private Counter[] CounterList = new Counter[16];
        private int CounterCount = 0;
        private int CounterNameCount = 1;
        
        // Task property
		private Task[] TaskList = new Task[16];
        private int TaskCounter = 0;
        private int TaskNameCounter = 1;
        // Alarm Property
        private Alarm[] AlarmList = new Alarm[16];
        private int AlarmCounter = 0;
        private int AlarmNameCounter = 0;
		private System.Windows.Forms.Button NewFileButton;
		private System.Windows.Forms.Button OpenFileButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button GenerateButton;
		private System.Windows.Forms.Button StatisticsButton;
		private System.Windows.Forms.ToolTip toolTipNew;
		private System.Windows.Forms.Button ValidateIt;
		private System.ComponentModel.IContainer components;
        private System.Windows.Forms.SaveFileDialog writeToFileSaveFileDialog;
        private TabControl tabControl;
        private TabPage OS;
        private TabPage Task;
        private GroupBox TaskProperty;
        private Label label15;
        private TextBox Comment8;
        private Label label16;
        private TextBox Comment7;
        private Label label14;
        private ComboBox TaskResource;
        private Label label12;
        private TextBox Comment6;
        private Label label11;
        private TextBox Comment5;
        private Label label10;
        private TextBox Comment4;
        private Label label9;
        private TextBox Comment3;
        private Label label8;
        private TextBox Comment2;
        private Label label7;
        private Label label6;
        private ComboBox TskCallScheduler;
        private Label label5;
        private TextBox TaskStackSize;
        private Label label4;
        private ComboBox TaskSchedule;
        private Label label3;
        private TextBox TaskActivation;
        private Label label2;
        private Label label1;
        private ComboBox TaskType;
        private TextBox TaskPriority;
        private TextBox Comment1;
        private Label label13;
        private ComboBox TaskEvent;
        private TabPage ISR;
        private TabPage Counter;
        private TabPage AppMode;
        private TabPage Alarm;
        private TabPage Event;
        private TabPage RESOURCE;
        private Label label17;
        private ComboBox MicroSelection;
        private TextBox MicroComment;
        private ComboBox CC;
        private Label label19;
        private CheckBox Enabled_ISR_Nesting;
        private Label label18;
        private CheckBox STARTUP_HOOK_ENABLED;
        private Label label20;
        private CheckBox ERROR_CHECKING_EXTENDEDK_ENABLED;
        private Label ErrCheckExtended;
        private CheckBox STACK_CHECK_ENABLED;
        private Label StackChck;
        private TextBox CC_Comment;
        private CheckBox POSTISR_HOOK_ENABLED;
        private Label label24;
        private CheckBox PREISR_HOOK_ENABLED;
        private Label label25;
        private CheckBox POSTTASK_HOOK_ENABLED;
        private Label label23;
        private CheckBox PRETASK_HOOK_ENABLED;
        private Label label22;
        private CheckBox SHUTDOWN_HOOK_ENABLED;
        private Label label21;
        private TextBox MINCYCLE;
        private Label label27;
        private ComboBox SELECT_TIMER;
        private Label label26;
        private TextBox MAXALLOWEDVALUE;
        private Label label28;
        private TextBox TIME_IN_NS;
        private Label label29;
        private TextBox TICKPERBASE;
        private Label label30;
        private ComboBox COUNTER_SELECTOR;
        private Label label31;
        private GroupBox groupBox2;
        private Label label32;
        private GroupBox groupBox1;
        private TextBox CYCLE_TIME_VALUE;
        private Label label34;
        private TextBox AUTOSTART_ALARM_TIME;
        private Label label33;
        private CheckBox ALARM_AUTOSTART_ENABLED;
        private GroupBox groupBox3;
        private ComboBox ALARM_ACTION;
        private TextBox AlarmToEvent;
        private Label label37;
        private TextBox AlarmToTask;
        private Label label38;
        private Label label39;
        private ComboBox Alarm_appmode_selector;
        private Label label35;
        private TextBox AlarmCallBack;
        private Label ALARM_TO_CALLBACK;
        private CheckBox AutoStartTask;
        private Button PathButton;
        private TextBox PathToGenerate;
        private FolderBrowserDialog folderBrowserDialog1;

        


		public OSEKForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            OS_FORM = new OS();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("OS");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("TASK");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("ISR");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("COUNTER");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("APPMODE");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("ALARM");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("EVENT");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("RESOURCE");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("OSEK_CONF", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OSEKForm));
            this.OStree = new System.Windows.Forms.TreeView();
            this.MyContext = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.NewFileButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ValidateIt = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.StatisticsButton = new System.Windows.Forms.Button();
            this.writeToFileSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTipNew = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.OS = new System.Windows.Forms.TabPage();
            this.POSTISR_HOOK_ENABLED = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.PREISR_HOOK_ENABLED = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.POSTTASK_HOOK_ENABLED = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.PRETASK_HOOK_ENABLED = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.SHUTDOWN_HOOK_ENABLED = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.STARTUP_HOOK_ENABLED = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ERROR_CHECKING_EXTENDEDK_ENABLED = new System.Windows.Forms.CheckBox();
            this.ErrCheckExtended = new System.Windows.Forms.Label();
            this.STACK_CHECK_ENABLED = new System.Windows.Forms.CheckBox();
            this.StackChck = new System.Windows.Forms.Label();
            this.CC_Comment = new System.Windows.Forms.TextBox();
            this.MicroComment = new System.Windows.Forms.TextBox();
            this.CC = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Enabled_ISR_Nesting = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.MicroSelection = new System.Windows.Forms.ComboBox();
            this.Task = new System.Windows.Forms.TabPage();
            this.TaskProperty = new System.Windows.Forms.GroupBox();
            this.AutoStartTask = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Comment8 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Comment7 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TaskResource = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Comment6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Comment5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Comment4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Comment3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Comment2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TskCallScheduler = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TaskStackSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TaskSchedule = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TaskActivation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TaskType = new System.Windows.Forms.ComboBox();
            this.TaskPriority = new System.Windows.Forms.TextBox();
            this.Comment1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TaskEvent = new System.Windows.Forms.ComboBox();
            this.ISR = new System.Windows.Forms.TabPage();
            this.Counter = new System.Windows.Forms.TabPage();
            this.TIME_IN_NS = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.TICKPERBASE = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.MAXALLOWEDVALUE = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.MINCYCLE = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.SELECT_TIMER = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.AppMode = new System.Windows.Forms.TabPage();
            this.Alarm = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AlarmCallBack = new System.Windows.Forms.TextBox();
            this.ALARM_TO_CALLBACK = new System.Windows.Forms.Label();
            this.ALARM_ACTION = new System.Windows.Forms.ComboBox();
            this.AlarmToEvent = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.AlarmToTask = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Alarm_appmode_selector = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.CYCLE_TIME_VALUE = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.AUTOSTART_ALARM_TIME = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.ALARM_AUTOSTART_ENABLED = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.COUNTER_SELECTOR = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.Event = new System.Windows.Forms.TabPage();
            this.RESOURCE = new System.Windows.Forms.TabPage();
            this.PathButton = new System.Windows.Forms.Button();
            this.PathToGenerate = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl.SuspendLayout();
            this.OS.SuspendLayout();
            this.Task.SuspendLayout();
            this.TaskProperty.SuspendLayout();
            this.Counter.SuspendLayout();
            this.Alarm.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OStree
            // 
            this.OStree.LabelEdit = true;
            this.OStree.Location = new System.Drawing.Point(8, 64);
            this.OStree.Name = "OStree";
            treeNode1.Name = "OSNode";
            treeNode1.Tag = "";
            treeNode1.Text = "OS";
            treeNode2.Name = "TASKNode";
            treeNode2.Text = "TASK";
            treeNode3.Name = "ISRNode";
            treeNode3.Text = "ISR";
            treeNode4.Name = "COUNTERNode";
            treeNode4.Text = "COUNTER";
            treeNode5.Name = "APPMODENode";
            treeNode5.Text = "APPMODE";
            treeNode6.Name = "ALARMNode";
            treeNode6.Text = "ALARM";
            treeNode7.Name = "EVENTNode";
            treeNode7.Text = "EVENT";
            treeNode8.Name = "RESOURCENode";
            treeNode8.Text = "RESOURCE";
            treeNode9.Name = "OSEK_CONF_Node";
            treeNode9.Text = "OSEK_CONF";
            this.OStree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.OStree.Size = new System.Drawing.Size(232, 504);
            this.OStree.TabIndex = 0;
            this.OStree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.OStree_AfterLabelEdit);
            this.OStree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.NewSelectedItem);
            this.OStree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseIsClick);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = -1;
            this.menuItem1.Text = "";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = -1;
            this.menuItem2.Text = "";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = -1;
            this.menuItem3.Text = "";
            // 
            // NewFileButton
            // 
            this.NewFileButton.Image = ((System.Drawing.Image)(resources.GetObject("NewFileButton.Image")));
            this.NewFileButton.Location = new System.Drawing.Point(16, 16);
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Size = new System.Drawing.Size(40, 40);
            this.NewFileButton.TabIndex = 3;
            this.toolTipNew.SetToolTip(this.NewFileButton, "toolTipNew");
            this.NewFileButton.Click += new System.EventHandler(this.NewFileButton_Click);
            this.NewFileButton.MouseHover += new System.EventHandler(this.MouseOver_NewButton);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileButton.Image")));
            this.OpenFileButton.Location = new System.Drawing.Point(72, 16);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(40, 40);
            this.OpenFileButton.TabIndex = 4;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            this.OpenFileButton.MouseHover += new System.EventHandler(this.MouseOver_OpenButton);
            // 
            // SaveButton
            // 
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(128, 16);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(40, 40);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            this.SaveButton.MouseHover += new System.EventHandler(this.MouseOver_SaveButton);
            // 
            // ValidateIt
            // 
            this.ValidateIt.Enabled = false;
            this.ValidateIt.Image = ((System.Drawing.Image)(resources.GetObject("ValidateIt.Image")));
            this.ValidateIt.Location = new System.Drawing.Point(184, 16);
            this.ValidateIt.Name = "ValidateIt";
            this.ValidateIt.Size = new System.Drawing.Size(40, 40);
            this.ValidateIt.TabIndex = 7;
            this.ValidateIt.Click += new System.EventHandler(this.ValidateIt_Click);
            this.ValidateIt.MouseHover += new System.EventHandler(this.MouseOver_);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Image = ((System.Drawing.Image)(resources.GetObject("GenerateButton.Image")));
            this.GenerateButton.Location = new System.Drawing.Point(240, 16);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(40, 40);
            this.GenerateButton.TabIndex = 8;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            this.GenerateButton.MouseHover += new System.EventHandler(this.MouseOver_Generated);
            // 
            // StatisticsButton
            // 
            this.StatisticsButton.Image = ((System.Drawing.Image)(resources.GetObject("StatisticsButton.Image")));
            this.StatisticsButton.Location = new System.Drawing.Point(300, 16);
            this.StatisticsButton.Name = "StatisticsButton";
            this.StatisticsButton.Size = new System.Drawing.Size(40, 40);
            this.StatisticsButton.TabIndex = 29;
            this.StatisticsButton.Click += new System.EventHandler(this.StatisticsButton_Click);
            this.StatisticsButton.MouseHover += new System.EventHandler(this.MouseOver_StatisticsButton);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.OS);
            this.tabControl.Controls.Add(this.Task);
            this.tabControl.Controls.Add(this.ISR);
            this.tabControl.Controls.Add(this.Counter);
            this.tabControl.Controls.Add(this.AppMode);
            this.tabControl.Controls.Add(this.Alarm);
            this.tabControl.Controls.Add(this.Event);
            this.tabControl.Controls.Add(this.RESOURCE);
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(246, 86);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(542, 483);
            this.tabControl.TabIndex = 30;
            this.tabControl.Visible = false;
            // 
            // OS
            // 
            this.OS.Controls.Add(this.POSTISR_HOOK_ENABLED);
            this.OS.Controls.Add(this.label24);
            this.OS.Controls.Add(this.PREISR_HOOK_ENABLED);
            this.OS.Controls.Add(this.label25);
            this.OS.Controls.Add(this.POSTTASK_HOOK_ENABLED);
            this.OS.Controls.Add(this.label23);
            this.OS.Controls.Add(this.PRETASK_HOOK_ENABLED);
            this.OS.Controls.Add(this.label22);
            this.OS.Controls.Add(this.SHUTDOWN_HOOK_ENABLED);
            this.OS.Controls.Add(this.label21);
            this.OS.Controls.Add(this.STARTUP_HOOK_ENABLED);
            this.OS.Controls.Add(this.label20);
            this.OS.Controls.Add(this.ERROR_CHECKING_EXTENDEDK_ENABLED);
            this.OS.Controls.Add(this.ErrCheckExtended);
            this.OS.Controls.Add(this.STACK_CHECK_ENABLED);
            this.OS.Controls.Add(this.StackChck);
            this.OS.Controls.Add(this.CC_Comment);
            this.OS.Controls.Add(this.MicroComment);
            this.OS.Controls.Add(this.CC);
            this.OS.Controls.Add(this.label19);
            this.OS.Controls.Add(this.Enabled_ISR_Nesting);
            this.OS.Controls.Add(this.label18);
            this.OS.Controls.Add(this.label17);
            this.OS.Controls.Add(this.MicroSelection);
            this.OS.Location = new System.Drawing.Point(4, 22);
            this.OS.Name = "OS";
            this.OS.Padding = new System.Windows.Forms.Padding(3);
            this.OS.Size = new System.Drawing.Size(534, 457);
            this.OS.TabIndex = 1;
            this.OS.Text = "OS";
            this.OS.UseVisualStyleBackColor = true;
            // 
            // POSTISR_HOOK_ENABLED
            // 
            this.POSTISR_HOOK_ENABLED.AutoSize = true;
            this.POSTISR_HOOK_ENABLED.Location = new System.Drawing.Point(226, 297);
            this.POSTISR_HOOK_ENABLED.Name = "POSTISR_HOOK_ENABLED";
            this.POSTISR_HOOK_ENABLED.Size = new System.Drawing.Size(15, 14);
            this.POSTISR_HOOK_ENABLED.TabIndex = 24;
            this.POSTISR_HOOK_ENABLED.UseVisualStyleBackColor = true;
            this.POSTISR_HOOK_ENABLED.CheckedChanged += new System.EventHandler(this.POSTISR_HOOK_ENABLED_CheckedChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 298);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(91, 13);
            this.label24.TabIndex = 23;
            this.label24.Text = "POSTISR_HOOK";
            // 
            // PREISR_HOOK_ENABLED
            // 
            this.PREISR_HOOK_ENABLED.AutoSize = true;
            this.PREISR_HOOK_ENABLED.Location = new System.Drawing.Point(226, 267);
            this.PREISR_HOOK_ENABLED.Name = "PREISR_HOOK_ENABLED";
            this.PREISR_HOOK_ENABLED.Size = new System.Drawing.Size(15, 14);
            this.PREISR_HOOK_ENABLED.TabIndex = 22;
            this.PREISR_HOOK_ENABLED.UseVisualStyleBackColor = true;
            this.PREISR_HOOK_ENABLED.CheckedChanged += new System.EventHandler(this.PREISR_HOOK_ENABLED_CheckedChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 268);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 13);
            this.label25.TabIndex = 21;
            this.label25.Text = "PREISR_HOOK";
            // 
            // POSTTASK_HOOK_ENABLED
            // 
            this.POSTTASK_HOOK_ENABLED.AutoSize = true;
            this.POSTTASK_HOOK_ENABLED.Location = new System.Drawing.Point(226, 238);
            this.POSTTASK_HOOK_ENABLED.Name = "POSTTASK_HOOK_ENABLED";
            this.POSTTASK_HOOK_ENABLED.Size = new System.Drawing.Size(15, 14);
            this.POSTTASK_HOOK_ENABLED.TabIndex = 20;
            this.POSTTASK_HOOK_ENABLED.UseVisualStyleBackColor = true;
            this.POSTTASK_HOOK_ENABLED.CheckedChanged += new System.EventHandler(this.POSTTASK_HOOK_ENABLED_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 239);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(101, 13);
            this.label23.TabIndex = 19;
            this.label23.Text = "POSTTASK_HOOK";
            // 
            // PRETASK_HOOK_ENABLED
            // 
            this.PRETASK_HOOK_ENABLED.AutoSize = true;
            this.PRETASK_HOOK_ENABLED.Location = new System.Drawing.Point(226, 208);
            this.PRETASK_HOOK_ENABLED.Name = "PRETASK_HOOK_ENABLED";
            this.PRETASK_HOOK_ENABLED.Size = new System.Drawing.Size(15, 14);
            this.PRETASK_HOOK_ENABLED.TabIndex = 18;
            this.PRETASK_HOOK_ENABLED.UseVisualStyleBackColor = true;
            this.PRETASK_HOOK_ENABLED.CheckedChanged += new System.EventHandler(this.PRETASK_HOOK_ENABLED_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 209);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 13);
            this.label22.TabIndex = 17;
            this.label22.Text = "PRETASK_HOOK";
            // 
            // SHUTDOWN_HOOK_ENABLED
            // 
            this.SHUTDOWN_HOOK_ENABLED.AutoSize = true;
            this.SHUTDOWN_HOOK_ENABLED.Location = new System.Drawing.Point(226, 179);
            this.SHUTDOWN_HOOK_ENABLED.Name = "SHUTDOWN_HOOK_ENABLED";
            this.SHUTDOWN_HOOK_ENABLED.Size = new System.Drawing.Size(15, 14);
            this.SHUTDOWN_HOOK_ENABLED.TabIndex = 16;
            this.SHUTDOWN_HOOK_ENABLED.UseVisualStyleBackColor = true;
            this.SHUTDOWN_HOOK_ENABLED.CheckedChanged += new System.EventHandler(this.SHUTDOWN_HOOK_ENABLED_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 180);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(109, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "SHUTDOWN_HOOK";
            // 
            // STARTUP_HOOK_ENABLED
            // 
            this.STARTUP_HOOK_ENABLED.AutoSize = true;
            this.STARTUP_HOOK_ENABLED.Location = new System.Drawing.Point(226, 149);
            this.STARTUP_HOOK_ENABLED.Name = "STARTUP_HOOK_ENABLED";
            this.STARTUP_HOOK_ENABLED.Size = new System.Drawing.Size(15, 14);
            this.STARTUP_HOOK_ENABLED.TabIndex = 14;
            this.STARTUP_HOOK_ENABLED.UseVisualStyleBackColor = true;
            this.STARTUP_HOOK_ENABLED.CheckedChanged += new System.EventHandler(this.STARTUP_HOOK_ENABLED_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 150);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "STARTUP_HOOK";
            // 
            // ERROR_CHECKING_EXTENDEDK_ENABLED
            // 
            this.ERROR_CHECKING_EXTENDEDK_ENABLED.AutoSize = true;
            this.ERROR_CHECKING_EXTENDEDK_ENABLED.Location = new System.Drawing.Point(226, 122);
            this.ERROR_CHECKING_EXTENDEDK_ENABLED.Name = "ERROR_CHECKING_EXTENDEDK_ENABLED";
            this.ERROR_CHECKING_EXTENDEDK_ENABLED.Size = new System.Drawing.Size(15, 14);
            this.ERROR_CHECKING_EXTENDEDK_ENABLED.TabIndex = 12;
            this.ERROR_CHECKING_EXTENDEDK_ENABLED.UseVisualStyleBackColor = true;
            this.ERROR_CHECKING_EXTENDEDK_ENABLED.CheckedChanged += new System.EventHandler(this.ERROR_CHECKING_EXTENDEDK_ENABLED_CheckedChanged);
            // 
            // ErrCheckExtended
            // 
            this.ErrCheckExtended.AutoSize = true;
            this.ErrCheckExtended.Location = new System.Drawing.Point(6, 122);
            this.ErrCheckExtended.Name = "ErrCheckExtended";
            this.ErrCheckExtended.Size = new System.Drawing.Size(172, 13);
            this.ErrCheckExtended.TabIndex = 11;
            this.ErrCheckExtended.Text = "ERROR_CHECKING_EXTENDED";
            // 
            // STACK_CHECK_ENABLED
            // 
            this.STACK_CHECK_ENABLED.AutoSize = true;
            this.STACK_CHECK_ENABLED.Location = new System.Drawing.Point(226, 97);
            this.STACK_CHECK_ENABLED.Name = "STACK_CHECK_ENABLED";
            this.STACK_CHECK_ENABLED.Size = new System.Drawing.Size(15, 14);
            this.STACK_CHECK_ENABLED.TabIndex = 10;
            this.STACK_CHECK_ENABLED.UseVisualStyleBackColor = true;
            this.STACK_CHECK_ENABLED.CheckedChanged += new System.EventHandler(this.STACK_CHECK_ENABLED_CheckedChanged);
            // 
            // StackChck
            // 
            this.StackChck.AutoSize = true;
            this.StackChck.Location = new System.Drawing.Point(6, 97);
            this.StackChck.Name = "StackChck";
            this.StackChck.Size = new System.Drawing.Size(84, 13);
            this.StackChck.TabIndex = 9;
            this.StackChck.Text = "STACK_CHECK";
            // 
            // CC_Comment
            // 
            this.CC_Comment.Location = new System.Drawing.Point(317, 63);
            this.CC_Comment.Name = "CC_Comment";
            this.CC_Comment.Size = new System.Drawing.Size(191, 20);
            this.CC_Comment.TabIndex = 8;
            // 
            // MicroComment
            // 
            this.MicroComment.Location = new System.Drawing.Point(317, 15);
            this.MicroComment.Name = "MicroComment";
            this.MicroComment.Size = new System.Drawing.Size(191, 20);
            this.MicroComment.TabIndex = 6;
            // 
            // CC
            // 
            this.CC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CC.FormattingEnabled = true;
            this.CC.Items.AddRange(new object[] {
            "BCC1",
            "BCC2",
            "ECC1",
            "ECC2"});
            this.CC.Location = new System.Drawing.Point(147, 68);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(121, 21);
            this.CC.TabIndex = 5;
            this.CC.SelectedIndexChanged += new System.EventHandler(this.CC_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "CC";
            // 
            // Enabled_ISR_Nesting
            // 
            this.Enabled_ISR_Nesting.AutoSize = true;
            this.Enabled_ISR_Nesting.Location = new System.Drawing.Point(226, 322);
            this.Enabled_ISR_Nesting.Name = "Enabled_ISR_Nesting";
            this.Enabled_ISR_Nesting.Size = new System.Drawing.Size(15, 14);
            this.Enabled_ISR_Nesting.TabIndex = 3;
            this.Enabled_ISR_Nesting.UseVisualStyleBackColor = true;
            this.Enabled_ISR_Nesting.CheckedChanged += new System.EventHandler(this.Enabled_ISR_Nesting_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 323);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "INTERRUPT_NESTING";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "MICROCONTROLLER";
            // 
            // MicroSelection
            // 
            this.MicroSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MicroSelection.FormattingEnabled = true;
            this.MicroSelection.Items.AddRange(new object[] {
            "MSP430FG4618",
            "MSP430F5438",
            "LPC2106",
            "Delfino TMS320F28335"});
            this.MicroSelection.Location = new System.Drawing.Point(147, 15);
            this.MicroSelection.Name = "MicroSelection";
            this.MicroSelection.Size = new System.Drawing.Size(121, 21);
            this.MicroSelection.TabIndex = 0;
            this.MicroSelection.SelectedIndexChanged += new System.EventHandler(this.MicroSelection_SelectedIndexChanged);
            // 
            // Task
            // 
            this.Task.Controls.Add(this.TaskProperty);
            this.Task.Location = new System.Drawing.Point(4, 22);
            this.Task.Name = "Task";
            this.Task.Padding = new System.Windows.Forms.Padding(3);
            this.Task.Size = new System.Drawing.Size(534, 457);
            this.Task.TabIndex = 0;
            this.Task.Text = "TASK";
            this.Task.UseVisualStyleBackColor = true;
            // 
            // TaskProperty
            // 
            this.TaskProperty.Controls.Add(this.AutoStartTask);
            this.TaskProperty.Controls.Add(this.label15);
            this.TaskProperty.Controls.Add(this.Comment8);
            this.TaskProperty.Controls.Add(this.label16);
            this.TaskProperty.Controls.Add(this.Comment7);
            this.TaskProperty.Controls.Add(this.label14);
            this.TaskProperty.Controls.Add(this.TaskResource);
            this.TaskProperty.Controls.Add(this.label12);
            this.TaskProperty.Controls.Add(this.Comment6);
            this.TaskProperty.Controls.Add(this.label11);
            this.TaskProperty.Controls.Add(this.Comment5);
            this.TaskProperty.Controls.Add(this.label10);
            this.TaskProperty.Controls.Add(this.Comment4);
            this.TaskProperty.Controls.Add(this.label9);
            this.TaskProperty.Controls.Add(this.Comment3);
            this.TaskProperty.Controls.Add(this.label8);
            this.TaskProperty.Controls.Add(this.Comment2);
            this.TaskProperty.Controls.Add(this.label7);
            this.TaskProperty.Controls.Add(this.label6);
            this.TaskProperty.Controls.Add(this.TskCallScheduler);
            this.TaskProperty.Controls.Add(this.label5);
            this.TaskProperty.Controls.Add(this.TaskStackSize);
            this.TaskProperty.Controls.Add(this.label4);
            this.TaskProperty.Controls.Add(this.TaskSchedule);
            this.TaskProperty.Controls.Add(this.label3);
            this.TaskProperty.Controls.Add(this.TaskActivation);
            this.TaskProperty.Controls.Add(this.label2);
            this.TaskProperty.Controls.Add(this.label1);
            this.TaskProperty.Controls.Add(this.TaskType);
            this.TaskProperty.Controls.Add(this.TaskPriority);
            this.TaskProperty.Controls.Add(this.Comment1);
            this.TaskProperty.Controls.Add(this.label13);
            this.TaskProperty.Controls.Add(this.TaskEvent);
            this.TaskProperty.Location = new System.Drawing.Point(6, 58);
            this.TaskProperty.Name = "TaskProperty";
            this.TaskProperty.Size = new System.Drawing.Size(523, 328);
            this.TaskProperty.TabIndex = 31;
            this.TaskProperty.TabStop = false;
            // 
            // AutoStartTask
            // 
            this.AutoStartTask.AutoSize = true;
            this.AutoStartTask.Location = new System.Drawing.Point(104, 305);
            this.AutoStartTask.Name = "AutoStartTask";
            this.AutoStartTask.Size = new System.Drawing.Size(94, 17);
            this.AutoStartTask.TabIndex = 29;
            this.AutoStartTask.Text = "Auto start task";
            this.AutoStartTask.UseVisualStyleBackColor = true;
            this.AutoStartTask.CheckedChanged += new System.EventHandler(this.AutoStartTask_CheckedChanged);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(248, 264);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 16);
            this.label15.TabIndex = 28;
            this.label15.Text = "Comment";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Comment8
            // 
            this.Comment8.Location = new System.Drawing.Point(336, 264);
            this.Comment8.Name = "Comment8";
            this.Comment8.Size = new System.Drawing.Size(176, 20);
            this.Comment8.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(248, 232);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 16);
            this.label16.TabIndex = 26;
            this.label16.Text = "Comment";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Comment7
            // 
            this.Comment7.Location = new System.Drawing.Point(336, 232);
            this.Comment7.Name = "Comment7";
            this.Comment7.Size = new System.Drawing.Size(176, 20);
            this.Comment7.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(16, 264);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "Resource";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TaskResource
            // 
            this.TaskResource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaskResource.Location = new System.Drawing.Point(104, 264);
            this.TaskResource.Name = "TaskResource";
            this.TaskResource.Size = new System.Drawing.Size(121, 21);
            this.TaskResource.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(248, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Comment";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Comment6
            // 
            this.Comment6.Location = new System.Drawing.Point(336, 200);
            this.Comment6.Name = "Comment6";
            this.Comment6.Size = new System.Drawing.Size(176, 20);
            this.Comment6.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(248, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Comment";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Comment5
            // 
            this.Comment5.Location = new System.Drawing.Point(336, 168);
            this.Comment5.Name = "Comment5";
            this.Comment5.Size = new System.Drawing.Size(176, 20);
            this.Comment5.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(248, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Comment";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Comment4
            // 
            this.Comment4.Location = new System.Drawing.Point(336, 136);
            this.Comment4.Name = "Comment4";
            this.Comment4.Size = new System.Drawing.Size(176, 20);
            this.Comment4.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(248, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Comment";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Comment3
            // 
            this.Comment3.Location = new System.Drawing.Point(336, 104);
            this.Comment3.Name = "Comment3";
            this.Comment3.Size = new System.Drawing.Size(176, 20);
            this.Comment3.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(248, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Comment";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Comment2
            // 
            this.Comment2.Location = new System.Drawing.Point(336, 72);
            this.Comment2.Name = "Comment2";
            this.Comment2.Size = new System.Drawing.Size(176, 20);
            this.Comment2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(248, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Comment";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Call Scheduler";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TskCallScheduler
            // 
            this.TskCallScheduler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TskCallScheduler.Items.AddRange(new object[] {
            "",
            "DONTKNOW",
            "YES",
            "NO"});
            this.TskCallScheduler.Location = new System.Drawing.Point(104, 200);
            this.TskCallScheduler.Name = "TskCallScheduler";
            this.TskCallScheduler.Size = new System.Drawing.Size(121, 21);
            this.TskCallScheduler.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Task Stack Size";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TaskStackSize
            // 
            this.TaskStackSize.Location = new System.Drawing.Point(104, 168);
            this.TaskStackSize.Name = "TaskStackSize";
            this.TaskStackSize.Size = new System.Drawing.Size(120, 20);
            this.TaskStackSize.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Task Schedule";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TaskSchedule
            // 
            this.TaskSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaskSchedule.Items.AddRange(new object[] {
            "",
            "FULL",
            "NON"});
            this.TaskSchedule.Location = new System.Drawing.Point(104, 136);
            this.TaskSchedule.Name = "TaskSchedule";
            this.TaskSchedule.Size = new System.Drawing.Size(121, 21);
            this.TaskSchedule.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Task Activation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TaskActivation
            // 
            this.TaskActivation.Location = new System.Drawing.Point(104, 104);
            this.TaskActivation.Name = "TaskActivation";
            this.TaskActivation.Size = new System.Drawing.Size(120, 20);
            this.TaskActivation.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task Priority";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Task Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TaskType
            // 
            this.TaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaskType.Items.AddRange(new object[] {
            "AUTO",
            "BASIC",
            "EXTENDED"});
            this.TaskType.Location = new System.Drawing.Point(104, 40);
            this.TaskType.Name = "TaskType";
            this.TaskType.Size = new System.Drawing.Size(121, 21);
            this.TaskType.TabIndex = 1;
            // 
            // TaskPriority
            // 
            this.TaskPriority.Location = new System.Drawing.Point(104, 72);
            this.TaskPriority.MaxLength = 255;
            this.TaskPriority.Name = "TaskPriority";
            this.TaskPriority.Size = new System.Drawing.Size(120, 20);
            this.TaskPriority.TabIndex = 0;
            // 
            // Comment1
            // 
            this.Comment1.Location = new System.Drawing.Point(336, 40);
            this.Comment1.Name = "Comment1";
            this.Comment1.Size = new System.Drawing.Size(176, 20);
            this.Comment1.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(16, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "Event";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TaskEvent
            // 
            this.TaskEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaskEvent.Items.AddRange(new object[] {
            ""});
            this.TaskEvent.Location = new System.Drawing.Point(104, 232);
            this.TaskEvent.Name = "TaskEvent";
            this.TaskEvent.Size = new System.Drawing.Size(121, 21);
            this.TaskEvent.TabIndex = 12;
            // 
            // ISR
            // 
            this.ISR.Location = new System.Drawing.Point(4, 22);
            this.ISR.Name = "ISR";
            this.ISR.Size = new System.Drawing.Size(534, 457);
            this.ISR.TabIndex = 2;
            this.ISR.Text = "ISR";
            this.ISR.UseVisualStyleBackColor = true;
            // 
            // Counter
            // 
            this.Counter.Controls.Add(this.TIME_IN_NS);
            this.Counter.Controls.Add(this.label29);
            this.Counter.Controls.Add(this.TICKPERBASE);
            this.Counter.Controls.Add(this.label30);
            this.Counter.Controls.Add(this.MAXALLOWEDVALUE);
            this.Counter.Controls.Add(this.label28);
            this.Counter.Controls.Add(this.MINCYCLE);
            this.Counter.Controls.Add(this.label27);
            this.Counter.Controls.Add(this.SELECT_TIMER);
            this.Counter.Controls.Add(this.label26);
            this.Counter.Location = new System.Drawing.Point(4, 22);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(534, 457);
            this.Counter.TabIndex = 3;
            this.Counter.Text = "COUNTER";
            this.Counter.UseVisualStyleBackColor = true;
            // 
            // TIME_IN_NS
            // 
            this.TIME_IN_NS.Location = new System.Drawing.Point(189, 205);
            this.TIME_IN_NS.Name = "TIME_IN_NS";
            this.TIME_IN_NS.Size = new System.Drawing.Size(121, 20);
            this.TIME_IN_NS.TabIndex = 9;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(14, 208);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(71, 13);
            this.label29.TabIndex = 8;
            this.label29.Text = "TIME_IN_NS";
            // 
            // TICKPERBASE
            // 
            this.TICKPERBASE.Location = new System.Drawing.Point(189, 162);
            this.TICKPERBASE.Name = "TICKPERBASE";
            this.TICKPERBASE.Size = new System.Drawing.Size(121, 20);
            this.TICKPERBASE.TabIndex = 7;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(14, 169);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(81, 13);
            this.label30.TabIndex = 6;
            this.label30.Text = "TICKPERBASE";
            // 
            // MAXALLOWEDVALUE
            // 
            this.MAXALLOWEDVALUE.Location = new System.Drawing.Point(189, 117);
            this.MAXALLOWEDVALUE.Name = "MAXALLOWEDVALUE";
            this.MAXALLOWEDVALUE.Size = new System.Drawing.Size(121, 20);
            this.MAXALLOWEDVALUE.TabIndex = 5;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(14, 120);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(118, 13);
            this.label28.TabIndex = 4;
            this.label28.Text = "MAXALLOWEDVALUE";
            // 
            // MINCYCLE
            // 
            this.MINCYCLE.Location = new System.Drawing.Point(189, 74);
            this.MINCYCLE.Name = "MINCYCLE";
            this.MINCYCLE.Size = new System.Drawing.Size(121, 20);
            this.MINCYCLE.TabIndex = 3;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(14, 81);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 13);
            this.label27.TabIndex = 2;
            this.label27.Text = "MINCYCLE";
            // 
            // SELECT_TIMER
            // 
            this.SELECT_TIMER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SELECT_TIMER.FormattingEnabled = true;
            this.SELECT_TIMER.Items.AddRange(new object[] {
            "USERCOUNTER",
            "TIMER_A",
            "TIMER_B"});
            this.SELECT_TIMER.Location = new System.Drawing.Point(189, 26);
            this.SELECT_TIMER.Name = "SELECT_TIMER";
            this.SELECT_TIMER.Size = new System.Drawing.Size(121, 21);
            this.SELECT_TIMER.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(14, 34);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "TICK_TIMER";
            // 
            // AppMode
            // 
            this.AppMode.Location = new System.Drawing.Point(4, 22);
            this.AppMode.Name = "AppMode";
            this.AppMode.Size = new System.Drawing.Size(534, 457);
            this.AppMode.TabIndex = 4;
            this.AppMode.Text = "APPMODE";
            this.AppMode.UseVisualStyleBackColor = true;
            // 
            // Alarm
            // 
            this.Alarm.Controls.Add(this.groupBox3);
            this.Alarm.Controls.Add(this.groupBox2);
            this.Alarm.Controls.Add(this.groupBox1);
            this.Alarm.Location = new System.Drawing.Point(4, 22);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(534, 457);
            this.Alarm.TabIndex = 5;
            this.Alarm.Text = "ALARM";
            this.Alarm.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AlarmCallBack);
            this.groupBox3.Controls.Add(this.ALARM_TO_CALLBACK);
            this.groupBox3.Controls.Add(this.ALARM_ACTION);
            this.groupBox3.Controls.Add(this.AlarmToEvent);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.AlarmToTask);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Location = new System.Drawing.Point(8, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 173);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // AlarmCallBack
            // 
            this.AlarmCallBack.Location = new System.Drawing.Point(217, 123);
            this.AlarmCallBack.Name = "AlarmCallBack";
            this.AlarmCallBack.Size = new System.Drawing.Size(270, 20);
            this.AlarmCallBack.TabIndex = 8;
            // 
            // ALARM_TO_CALLBACK
            // 
            this.ALARM_TO_CALLBACK.AutoSize = true;
            this.ALARM_TO_CALLBACK.Location = new System.Drawing.Point(15, 126);
            this.ALARM_TO_CALLBACK.Name = "ALARM_TO_CALLBACK";
            this.ALARM_TO_CALLBACK.Size = new System.Drawing.Size(98, 13);
            this.ALARM_TO_CALLBACK.TabIndex = 7;
            this.ALARM_TO_CALLBACK.Text = "ALARMCALLBACK";
            // 
            // ALARM_ACTION
            // 
            this.ALARM_ACTION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ALARM_ACTION.FormattingEnabled = true;
            this.ALARM_ACTION.Items.AddRange(new object[] {
            "ACTIVATETASK",
            "SETEVENT",
            "ALARMCALLBACK"});
            this.ALARM_ACTION.Location = new System.Drawing.Point(217, 26);
            this.ALARM_ACTION.Name = "ALARM_ACTION";
            this.ALARM_ACTION.Size = new System.Drawing.Size(121, 21);
            this.ALARM_ACTION.TabIndex = 6;
            // 
            // AlarmToEvent
            // 
            this.AlarmToEvent.Location = new System.Drawing.Point(217, 92);
            this.AlarmToEvent.Name = "AlarmToEvent";
            this.AlarmToEvent.Size = new System.Drawing.Size(270, 20);
            this.AlarmToEvent.TabIndex = 5;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(15, 95);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(43, 13);
            this.label37.TabIndex = 4;
            this.label37.Text = "EVENT";
            // 
            // AlarmToTask
            // 
            this.AlarmToTask.Location = new System.Drawing.Point(217, 59);
            this.AlarmToTask.Name = "AlarmToTask";
            this.AlarmToTask.Size = new System.Drawing.Size(270, 20);
            this.AlarmToTask.TabIndex = 3;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(15, 62);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(35, 13);
            this.label38.TabIndex = 2;
            this.label38.Text = "TASK";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(15, 29);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(47, 13);
            this.label39.TabIndex = 0;
            this.label39.Text = "ACTION";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Alarm_appmode_selector);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.CYCLE_TIME_VALUE);
            this.groupBox2.Controls.Add(this.label34);
            this.groupBox2.Controls.Add(this.AUTOSTART_ALARM_TIME);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.ALARM_AUTOSTART_ENABLED);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Location = new System.Drawing.Point(8, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 185);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alarms";
            // 
            // Alarm_appmode_selector
            // 
            this.Alarm_appmode_selector.FormattingEnabled = true;
            this.Alarm_appmode_selector.Location = new System.Drawing.Point(217, 124);
            this.Alarm_appmode_selector.Name = "Alarm_appmode_selector";
            this.Alarm_appmode_selector.Size = new System.Drawing.Size(121, 21);
            this.Alarm_appmode_selector.TabIndex = 2;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(15, 127);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(60, 13);
            this.label35.TabIndex = 6;
            this.label35.Text = "APPMODE";
            // 
            // CYCLE_TIME_VALUE
            // 
            this.CYCLE_TIME_VALUE.Location = new System.Drawing.Point(217, 95);
            this.CYCLE_TIME_VALUE.Name = "CYCLE_TIME_VALUE";
            this.CYCLE_TIME_VALUE.Size = new System.Drawing.Size(270, 20);
            this.CYCLE_TIME_VALUE.TabIndex = 5;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(15, 95);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(70, 13);
            this.label34.TabIndex = 4;
            this.label34.Text = "CYCLICTIME";
            // 
            // AUTOSTART_ALARM_TIME
            // 
            this.AUTOSTART_ALARM_TIME.Location = new System.Drawing.Point(217, 59);
            this.AUTOSTART_ALARM_TIME.Name = "AUTOSTART_ALARM_TIME";
            this.AUTOSTART_ALARM_TIME.Size = new System.Drawing.Size(270, 20);
            this.AUTOSTART_ALARM_TIME.TabIndex = 3;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(15, 62);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(70, 13);
            this.label33.TabIndex = 2;
            this.label33.Text = "ALARMTIME";
            // 
            // ALARM_AUTOSTART_ENABLED
            // 
            this.ALARM_AUTOSTART_ENABLED.AutoSize = true;
            this.ALARM_AUTOSTART_ENABLED.Location = new System.Drawing.Point(217, 25);
            this.ALARM_AUTOSTART_ENABLED.Name = "ALARM_AUTOSTART_ENABLED";
            this.ALARM_AUTOSTART_ENABLED.Size = new System.Drawing.Size(15, 14);
            this.ALARM_AUTOSTART_ENABLED.TabIndex = 1;
            this.ALARM_AUTOSTART_ENABLED.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(15, 29);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(73, 13);
            this.label32.TabIndex = 0;
            this.label32.Text = "AUTOSTART";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.COUNTER_SELECTOR);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Location = new System.Drawing.Point(8, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // COUNTER_SELECTOR
            // 
            this.COUNTER_SELECTOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COUNTER_SELECTOR.Location = new System.Drawing.Point(217, 21);
            this.COUNTER_SELECTOR.Name = "COUNTER_SELECTOR";
            this.COUNTER_SELECTOR.Size = new System.Drawing.Size(121, 21);
            this.COUNTER_SELECTOR.TabIndex = 1;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(15, 29);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(60, 13);
            this.label31.TabIndex = 0;
            this.label31.Text = "COUNTER";
            // 
            // Event
            // 
            this.Event.Location = new System.Drawing.Point(4, 22);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(534, 457);
            this.Event.TabIndex = 6;
            this.Event.Text = "EVENT";
            this.Event.UseVisualStyleBackColor = true;
            // 
            // RESOURCE
            // 
            this.RESOURCE.Location = new System.Drawing.Point(4, 22);
            this.RESOURCE.Name = "RESOURCE";
            this.RESOURCE.Size = new System.Drawing.Size(534, 457);
            this.RESOURCE.TabIndex = 7;
            this.RESOURCE.Text = "RESOURCE";
            this.RESOURCE.UseVisualStyleBackColor = true;
            // 
            // PathButton
            // 
            this.PathButton.Image = ((System.Drawing.Image)(resources.GetObject("PathButton.Image")));
            this.PathButton.Location = new System.Drawing.Point(361, 16);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(43, 40);
            this.PathButton.TabIndex = 31;
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            this.PathButton.MouseHover += new System.EventHandler(this.PathButton_MouseHover);
            // 
            // PathToGenerate
            // 
            this.PathToGenerate.Location = new System.Drawing.Point(422, 27);
            this.PathToGenerate.Name = "PathToGenerate";
            this.PathToGenerate.Size = new System.Drawing.Size(186, 20);
            this.PathToGenerate.TabIndex = 32;
            this.PathToGenerate.Text = "C:\\Generated\\";
            // 
            // OSEKForm
            // 
            this.AccessibleDescription = "Kristian\'s OS generator";
            this.AccessibleName = "OSEK_Generator";
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(806, 501);
            this.Controls.Add(this.PathToGenerate);
            this.Controls.Add(this.PathButton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.ValidateIt);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.NewFileButton);
            this.Controls.Add(this.OStree);
            this.Controls.Add(this.StatisticsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OSEKForm";
            this.Text = "Kristian\'s OS Generator";
            this.Load += new System.EventHandler(this.LoadForm);
            this.tabControl.ResumeLayout(false);
            this.OS.ResumeLayout(false);
            this.OS.PerformLayout();
            this.Task.ResumeLayout(false);
            this.TaskProperty.ResumeLayout(false);
            this.TaskProperty.PerformLayout();
            this.Counter.ResumeLayout(false);
            this.Counter.PerformLayout();
            this.Alarm.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        Assembly _assembly;
        Stream _imageStream;
        StreamReader _textStreamReader;
		//==============================================================================
		// DESCRIPTION :		
		//
		// PARAMETERS (Type,Name,Min,Max) :
		//
		// RETURN VALUE :
		//
		// DESIGN INFORMATION :
		//==============================================================================
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            
			Application.Run(new OSEKForm());
            

		}
		//==============================================================================
		// DESCRIPTION :		
		//
		// PARAMETERS (Type,Name,Min,Max) :
		//
		// RETURN VALUE :
		//
		// DESIGN INFORMATION :
		//==============================================================================
		private void LoadForm(object sender, System.EventArgs e)
		{
            
			OStree.ExpandAll();
			OStree.ContextMenu = MyContext;	
			ManageTaskProperty(false);
            ManageAlarmProperty(false);
            ManageCounterProperty(false);
			//TULogo.Image=new Bitmap("D:\\Projects\\Development\\NewOSEKGen\\NewOSEKGen\\icons\\logo_tu.jpg"); 
		//LogoImage.Image = new Bitmap("D:\\Projects\\Development\\NewOSEKGen\\NewOSEKGen\\icons\\logo_tu.jpg"); 
			SaveButton.Enabled = false;
			ValidateIt.Enabled = false;
			GenerateButton.Enabled = false;
			StatisticsButton.Enabled = false;
			OStree.Enabled = false;
			OStree.Visible = false;
            
            

		}
		//==============================================================================
		// DESCRIPTION :		
		//
		// PARAMETERS (Type,Name,Min,Max) :
		//
		// RETURN VALUE :
		//
		// DESIGN INFORMATION :
		//==============================================================================	
		private void NewSelectedItem(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			FormContextMenu();
			ManagePropertyMenu();
			ManageTskValues(false);
            ManageAlarmValues(false);
            ManageCounterValues(false);
		}


		
		//==============================================================================
		// DESCRIPTION :		
		//
		// PARAMETERS (Type,Name,Min,Max) :
		//
		// RETURN VALUE :
		//
		// DESIGN INFORMATION :
		//==============================================================================	
		private void ManagePropertyMenu()
		{
			ManageTaskProperty(false);
            ManageAlarmProperty(false);
            ManageCounterProperty(false);
			// First level
			if("OSEK_CONF" == OStree.SelectedNode.Text)
			{
			}
				//Second Level
			else if(
				    (null != OStree.SelectedNode.Parent)&&				
				    ("OSEK_CONF" == OStree.SelectedNode.Parent.Text)
				   )
			{
                
			}
				// Third level
			else if(
					(null != OStree.SelectedNode.Parent)&&
					(null != OStree.SelectedNode.Parent.Parent)&&
					("OSEK_CONF" == OStree.SelectedNode.Parent.Parent.Text)
					)
			{
       
				if("TASK" == OStree.SelectedNode.Parent.Text)
				{
					TaskProperty.Text = OStree.SelectedNode.Text;
                    this.tabControl.SelectedTab = this.Task;
					ManageTaskProperty(true);
                    
				}
                if ("ALARM" == OStree.SelectedNode.Parent.Text)
                {
                    //AlarmProperty.Text = OStree.SelectedNode.Text;
                    this.tabControl.SelectedTab = this.Alarm;
                    // Flush dropdown menu
                    COUNTER_SELECTOR.Items.Clear();
                    for (int i = 0; i < CounterCount; i++)
                    {
                        COUNTER_SELECTOR.Items.Add(CounterList[i].GetCounterName());                       
                    }
                    
                    ManageAlarmProperty(true);

                }
                if ("COUNTER" == OStree.SelectedNode.Parent.Text)
                {
                    //AlarmProperty.Text = OStree.SelectedNode.Text;
                    this.tabControl.SelectedTab = this.Counter;
                    ManageCounterProperty(true);

                }
                
			}
			else
			{
				MessageBox.Show("Unknown selection!");
			}
			
			
			}
		//==============================================================================
		// DESCRIPTION :		
		//
		// PARAMETERS (Type,Name,Min,Max) :
		//
		// RETURN VALUE :
		//
		// DESIGN INFORMATION :
		//==============================================================================
		private void MouseIsClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)  
			{  
				TreeNode CurrentSelectedNode = OStree.GetNodeAt(e.X, e.Y);
				if(null != CurrentSelectedNode)
				{			
					OStree.SelectedNode = CurrentSelectedNode;
					// FormContextMenu(); was here move to NewSelectedItem ==EXCEPTION==
					
				}								  
			}  
		}
		//==============================================================================
		// DESCRIPTION :		
		//
		// PARAMETERS (Type,Name,Min,Max) :
		//
		// RETURN VALUE :
		//
		// DESIGN INFORMATION :
		//==============================================================================
		private void OnMiceClick(object sender, EventArgs e)
		{
			DisableTaskEvents();
            DisableAlarmEvents();
            DisableCounterEvents();
			MenuItem miClicked = (MenuItem)sender;
			string item = miClicked.Text;
			string t = MyContext.ToString();
			if("OSEK_CONF" == OStree.SelectedNode.Text)
			{
				return;
			}
			else
			{
				if( (null != OStree.SelectedNode.Parent)&&
					("OSEK_CONF" == OStree.SelectedNode.Parent.Text)
					)
				{
					if("New" == item)
					{											
						OStree.SelectedNode.Nodes.Add("OSEK Properties");

						try
						{
							// OS should have only one set of property
							MyContext.MenuItems.Clear();
		
						}
						catch
						{
							MessageBox.Show("Problem in the clear context menu");
						}															
					}
					else if("Add" == item)
					{
						
						if("TASK" == OStree.SelectedNode.Text)
						{
                            string NameForm = OStree.SelectedNode.Text + "_Child" + TaskNameCounter.ToString();
                            TaskNameCounter++;
                            OStree.SelectedNode.Nodes.Add(NameForm);
							// Allocate space for task's struct
                            if (TaskCounter >= (int)15)
                            {
                                MessageBox.Show("Exceeeded max number of tasks");
                            }
                            
                            TaskList[TaskCounter] = new Task();
                            TaskList[TaskCounter++].SetTaskName(NameForm);
							
						}
                        if ("ALARM" == OStree.SelectedNode.Text)
                        {
                            string NameForm = OStree.SelectedNode.Text + "_Child" + AlarmNameCounter.ToString();
                            OStree.SelectedNode.Nodes.Add(NameForm);
                            AlarmNameCounter++;
                            // Allocate space for task's struct
                            if (AlarmCounter >= (int)15)
                            {
                                MessageBox.Show("Exceeeded max number of alarms");
                            }
                            AlarmList[AlarmCounter] = new Alarm();
                            AlarmList[AlarmCounter++].SetAlarmName(NameForm);
                            
                        }
                        if ("COUNTER" == OStree.SelectedNode.Text)
                        {
                            string NameForm = OStree.SelectedNode.Text + "_Child" + CounterNameCount.ToString();
                            OStree.SelectedNode.Nodes.Add(NameForm);
                            CounterNameCount++;
                            // Allocate space for task's struct
                            if (CounterCount >= (int)15)
                            {
                                MessageBox.Show("Exceeded max number of counters");
                            }
                            CounterList[CounterCount] = new Counter();
                            CounterList[CounterCount++].SetCounterName(NameForm);
                            //COUNTER_SELECTOR.Items.Insert(CounterCombox++,NameForm);

                        }
						
					}
					else
					{
						MessageBox.Show("Unkown context menu item for first deptch!");
					}
				}
				else if(
					(null != OStree.SelectedNode.Parent)&&
					(null != OStree.SelectedNode.Parent.Parent)&&
					("OSEK_CONF" == OStree.SelectedNode.Parent.Parent.Text)
					)
				{
					if("Delete" == item)
					{
						int i;
						if("TASK"  == OStree.SelectedNode.Parent.Text)
						{
							
							
							try
							{
                              
								for(i = OStree.SelectedNode.Index; (i < 15 && (null != TaskList[i+1])); i++)
								{																
									TaskList[i] = TaskList[i+1];								
								}														
								 TaskList[i] = null;								
								OStree.SelectedNode.Nodes.Remove(OStree.SelectedNode);
                                
								if(0 < TaskCounter)
								{
									TaskCounter--;
								}
                                ManageTaskProperty(false);
								
							}
							catch
							{
								MessageBox.Show("Failed remove a child node");						
							}
						}
                        if ("COUNTER" == OStree.SelectedNode.Parent.Text)
                        {
                            if (0 < CounterCount)
                            {
                                CounterCount--;
                            }

                            try
                            {

                                for (i = OStree.SelectedNode.Index; (i < 15 && (null != CounterList[i + 1])); i++)
                                {
                                    CounterList[i] = CounterList[i + 1];
                                }
                                CounterList[i] = null;
                                OStree.SelectedNode.Nodes.Remove(OStree.SelectedNode);
                                if (0 < AlarmCounter)
                                {
                                    CounterCount--;
                                }
                                ManageCounterProperty(false);
                                //COUNTER_SELECTOR.Items.Remove(OStree.SelectedNode.Index);
                                //CounterCombox--;
                            }
                            catch
                            {
                                MessageBox.Show("Failed remove a child node");
                            }
                        }
                        if ("ALARM" == OStree.SelectedNode.Parent.Text)
                        {
                            if (0 < AlarmCounter)
                            {
                                AlarmCounter--;
                            }

                            try
                            {
                                
                                

                                for (i = OStree.SelectedNode.Index; (i < 15 && (null != AlarmList[i + 1])); i++)
                                {
                                    AlarmList[i] = AlarmList[i + 1];
                                }
                                AlarmList[i] = null;
                                OStree.SelectedNode.Nodes.Remove(OStree.SelectedNode);
                                if (0 < AlarmCounter)
                                {
                                    AlarmCounter--;
                                }
                                ManageAlarmProperty(false);
                            }
                            catch
                            {
                                MessageBox.Show("Failed remove a child node");
                            }
                        }
						
						FormContextMenu();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
					}
					else if("Edit" == item)
					{
						if(!OStree.SelectedNode.IsEditing)
						{
					
							OStree.SelectedNode.BeginEdit();
						}
					
					}
					else
					{
						MessageBox.Show("Unkown context menu item for second depth!");
					}
				}
			}
			OStree.ExpandAll();
			EnableTaskEvents();
            EnableAlarmEvents();
            EnableCounterEvents();
		}
		//==============================================================================
		// DESCRIPTION :		
		//
		// PARAMETERS (Type,Name,Min,Max) :
		//
		// RETURN VALUE :
		//
		// DESIGN INFORMATION :
		//==============================================================================
		private void FormContextMenu()
		{
			if(null != MyContext.MenuItems)
			{
				MyContext.MenuItems.Clear();
			}
			else
			{
				MessageBox.Show("Problem in the clear context menu");
			}
			
			if(
				(null != this.OStree.SelectedNode.Parent) &&
				("OSEK_CONF" == this.OStree.SelectedNode.Parent.Text)
				)
			{
				if("OS" == this.OStree.SelectedNode.Text)					
				{															
					if(null == OStree.SelectedNode.FirstNode)
					{
                        this.tabControl.SelectedTab = this.OS;
							
					}					
				}
				else if(("TASK" == this.OStree.SelectedNode.Text))
				{
					this.menuItem1.Index = 1;
					MyContext.MenuItems.Add("Add",new EventHandler(OnMiceClick));
                    this.tabControl.SelectedTab = this.Task;
                                                                
                    
				}
				else if("ISR" == this.OStree.SelectedNode.Text)
				{
					this.menuItem1.Index = 1;
					MyContext.MenuItems.Add("Add",new EventHandler(OnMiceClick));
                    this.tabControl.SelectedTab = this.ISR;
				}
				else if("COUNTER" == this.OStree.SelectedNode.Text)
				{
					this.menuItem1.Index = 1;
					MyContext.MenuItems.Add("Add",new EventHandler(OnMiceClick));
                    this.tabControl.SelectedTab = this.Counter;			
				}
				else if("MESSAGE" == this.OStree.SelectedNode.Text)
				{
					this.menuItem1.Index = 1;
					MyContext.MenuItems.Add("Add",new EventHandler(OnMiceClick));				
				}
				else if("APPMODE" == this.OStree.SelectedNode.Text)
				{
					this.menuItem1.Index = 1;
					MyContext.MenuItems.Add("Add",new EventHandler(OnMiceClick));
                    this.tabControl.SelectedTab = this.AppMode;
				}
				else if("ALARM" == this.OStree.SelectedNode.Text)
				{
                              
					this.menuItem1.Index = 1;
					MyContext.MenuItems.Add("Add",new EventHandler(OnMiceClick));
                    this.tabControl.SelectedTab = this.Alarm;
				}
				else if("EVENT" == this.OStree.SelectedNode.Text)
				{
					this.menuItem1.Index = 1;
					MyContext.MenuItems.Add("Add",new EventHandler(OnMiceClick));
                    this.tabControl.SelectedTab = this.Event;
				}
				else if("RESOURCE" == this.OStree.SelectedNode.Text)
				{
					this.menuItem1.Index = 1;
					MyContext.MenuItems.Add("Add",new EventHandler(OnMiceClick));
                    this.tabControl.SelectedTab = this.RESOURCE;
				}	
			}
				// Second level of depth in the tree view
			else if(
				   (null != this.OStree.SelectedNode.Parent) &&
				   (null != this.OStree.SelectedNode.Parent.Parent) &&
				   ("OSEK_CONF" == this.OStree.SelectedNode.Parent.Parent.Text)
				   )
			{
				
				this.menuItem1.Index = 1;
				MyContext.MenuItems.Add("Edit",new EventHandler(OnMiceClick));
				this.menuItem1.Index = 2;
				MyContext.MenuItems.Add("Delete",new EventHandler(OnMiceClick));
								
			}
		}


		//==============================================================================
		// DESCRIPTION :		
		//
		// PARAMETERS (Type,Name,Min,Max) :
		//
		// RETURN VALUE :
		//
		// DESIGN INFORMATION :
		//==============================================================================			
		private void ManageTaskProperty(bool state)
		{
			TaskProperty.Visible = state;
			TaskType.Visible = state;
			label1.Visible = state;
			label2.Visible = state;
			label3.Visible = state;
			label4.Visible = state;
			label5.Visible = state;
			label6.Visible = state;
			label7.Visible = state;
			label8.Visible = state;
			label9.Visible = state;
			label10.Visible = state;
			label11.Visible = state;
			label12.Visible = state;
			label13.Visible = state;
			label14.Visible = state;
			label15.Visible = state;
			label16.Visible = state;
			TaskPriority.Visible = state;
			TaskActivation.Visible = state;
			TaskSchedule.Visible = state;
			TaskStackSize.Visible = state;
			TskCallScheduler.Visible = state;
			TaskEvent.Visible = state;
			TaskResource.Visible = state;
			Comment1.Visible = state;
			Comment2.Visible = state;
			Comment3.Visible = state;
			Comment4.Visible = state;
			Comment5.Visible = state;
			Comment6.Visible = state;
			Comment7.Visible = state;
			Comment8.Visible = state;
            AutoStartTask.Visible = state;
		}
        private void ManageAlarmProperty(bool state)
        {
            groupBox1.Visible = state;
            label31.Visible = state;
            COUNTER_SELECTOR.Visible = state;
            groupBox2.Visible = state;
            label32.Visible = state;
            ALARM_AUTOSTART_ENABLED.Visible = state;
            label33.Visible = state;
            label34.Visible = state;
            label35.Visible = state;
            AUTOSTART_ALARM_TIME.Visible = state;
            CYCLE_TIME_VALUE.Visible = state;
            Alarm_appmode_selector.Visible = state;
            groupBox3.Visible = state;
            label37.Visible = state;
            label38.Visible = state;
            label39.Visible = state;            

            ALARM_ACTION.Visible = state;
            AlarmToTask.Visible = state;
            AlarmToEvent.Visible = state;
            
            
        }
        void ManageCounterProperty(bool state)
        { 
            SELECT_TIMER.Visible = state;
            MINCYCLE.Visible = state;            
            MAXALLOWEDVALUE.Visible = state;           
            TICKPERBASE.Visible = state;
            TIME_IN_NS.Visible = state;
            label26.Visible = state;
            label27.Visible = state;
            label28.Visible = state;
            label29.Visible = state;
            label30.Visible = state;
            
            
        }
		private void TaskType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			ManageTskValues(true);
		}
        private void ManageAlarmValues(bool direction)
        {
            if ((null != OStree.SelectedNode.Parent) &&
               ("ALARM" == OStree.SelectedNode.Parent.Text)
                )
            {

                // true means - from the property to structure
                if (direction)
                {
                    //AlarmList[OStree.SelectedNode.Index].SetAlarmCounter(COUNTER_SELECTOR.Text);
                    if (ALARM_AUTOSTART_ENABLED.Checked)
                    {
                        AlarmList[OStree.SelectedNode.Index].SetAlarmAutostartEn("TRUE");
                    }
                    else
                    {
                        AlarmList[OStree.SelectedNode.Index].SetAlarmAutostartEn("FALSE");
                    }
                    AlarmList[OStree.SelectedNode.Index].SetAlarmCounter(COUNTER_SELECTOR.SelectedItem.ToString());
                    AlarmList[OStree.SelectedNode.Index].SetAutostart_Alarmtime(AUTOSTART_ALARM_TIME.Text);
                    AlarmList[OStree.SelectedNode.Index].SetAutostart_cycletime(CYCLE_TIME_VALUE.Text);
                    AlarmList[OStree.SelectedNode.Index].SetAutostart_appmode(Alarm_appmode_selector.Text);
                    AlarmList[OStree.SelectedNode.Index].SetACTION_TYPE(ALARM_ACTION.Text);
                    AlarmList[OStree.SelectedNode.Index].SetTASK_NAME(AlarmToTask.Text);
                    AlarmList[OStree.SelectedNode.Index].SetEVENT_NAME(AlarmToEvent.Text);
                    AlarmList[OStree.SelectedNode.Index].SetALARMCALLBACK(AlarmCallBack.Text);
                }
                else
                {
                    try
                    {
                        DisableAlarmEvents();

                        //COUNTER_SELECTOR.Text = AlarmList[OStree.SelectedNode.Index].GetAlarmCounter();
                        
                        COUNTER_SELECTOR.Text = AlarmList[OStree.SelectedNode.Index].GetAlarmCounter();
                        string t = AlarmList[OStree.SelectedNode.Index].GetAlarmAutostartEn();
                        if(0==(String.Compare(t,"TRUE"))) 
                            ALARM_AUTOSTART_ENABLED.Checked = true;
                        else
                            ALARM_AUTOSTART_ENABLED.Checked = false;
                        AUTOSTART_ALARM_TIME.Text = AlarmList[OStree.SelectedNode.Index].GetAutostart_Alarmtime();
                        CYCLE_TIME_VALUE.Text = AlarmList[OStree.SelectedNode.Index].GetAutostart_cycletime();
                        Alarm_appmode_selector.Text = AlarmList[OStree.SelectedNode.Index].GetAutostart_appmode();
                        ALARM_ACTION.Text = AlarmList[OStree.SelectedNode.Index].GetACTION_TYPE();
                        AlarmToTask.Text = AlarmList[OStree.SelectedNode.Index].GetTASK_NAME();
                        AlarmToEvent.Text = AlarmList[OStree.SelectedNode.Index].GetEVENT_NAME();
                        AlarmCallBack.Text = AlarmList[OStree.SelectedNode.Index].GetALARMCALLBACK();


                        EnableAlarmEvents();
                    }
                    catch
                    {
                        MessageBox.Show("Problem with loading information for alarms in form");
                    }
                }

            }

        }

		private void ManageTskValues(bool direction)
		{
			if((null != OStree.SelectedNode.Parent) &&
               ("TASK" == OStree.SelectedNode.Parent.Text)
				)
			{
				
				// true means - from the property to structure
				if(direction)
				{
                    TaskList[OStree.SelectedNode.Index].SetTaskName(OStree.SelectedNode.Text);
					TaskList[OStree.SelectedNode.Index].SetTaskCallScheduler(TskCallScheduler.Text);
					TaskList[OStree.SelectedNode.Index].SetTaskEvent(TaskEvent.Text);					
					TaskList[OStree.SelectedNode.Index].SetTaskPrio(TaskPriority.Text);
					TaskList[OStree.SelectedNode.Index].SetTaskResource(TaskResource.Text);					
					TaskList[OStree.SelectedNode.Index].SetTaskScheduler(TaskSchedule.Text);
					TaskList[OStree.SelectedNode.Index].SetTaskStackSize(TaskStackSize.Text);
					TaskList[OStree.SelectedNode.Index].SetTaskActivation(TaskActivation.Text);
					TaskList[OStree.SelectedNode.Index].SetTaskType(TaskType.Text);
                    bool state = AutoStartTask.Checked;
                    TaskList[OStree.SelectedNode.Index].SetAutoStartTask(state);
				}
				else
				{
					try{
                        if (null != TaskList[OStree.SelectedNode.Index])
                        {
                            DisableTaskEvents();
                            TskCallScheduler.Text = TaskList[OStree.SelectedNode.Index].GetTaskCallScheduler();
                            TaskEvent.Text = TaskList[OStree.SelectedNode.Index].GetTaskEvent();
                            TaskType.Text = TaskList[OStree.SelectedNode.Index].GetTaskName();
                            TaskPriority.Text = TaskList[OStree.SelectedNode.Index].GetTaskPrio();
                            TaskType.Text = TaskList[OStree.SelectedNode.Index].GetTaskType();
                            TaskStackSize.Text = TaskList[OStree.SelectedNode.Index].GetTaskStackSize();
                            TaskActivation.Text = TaskList[OStree.SelectedNode.Index].GetTaskTaskActivation();
                            TaskSchedule.Text = TaskList[OStree.SelectedNode.Index].GetTaskScheduler();
                            bool state = TaskList[OStree.SelectedNode.Index].GetAutoStartTask();
                            AutoStartTask.Checked = state;
                            EnableTaskEvents();
                        }
                        else
                        {
                            MessageBox.Show("Problem");
                        }
					}
					catch (Exception ex)
					{
						MessageBox.Show("Problem with loading information for tasks in form: ", ex.Message);
					}
				}
				
			}
			
		}

        private void ManageCounterValues(bool direction)
        {
            if ((null != OStree.SelectedNode.Parent) &&
               ("COUNTER" == OStree.SelectedNode.Parent.Text)
                )
            {

                // true means - from the property to structure
                if (direction)
                {
                    CounterList[OStree.SelectedNode.Index].SetCounterName(OStree.SelectedNode.Text);
                    CounterList[OStree.SelectedNode.Index].SetTimerName(SELECT_TIMER.Text);
                    CounterList[OStree.SelectedNode.Index].SetMinCycle(MINCYCLE.Text);
                    CounterList[OStree.SelectedNode.Index].SetMaxAllowedValue(MAXALLOWEDVALUE.Text);
                    CounterList[OStree.SelectedNode.Index].SetTickPerBase(TICKPERBASE.Text);
                    CounterList[OStree.SelectedNode.Index].SetTimeInNS(TIME_IN_NS.Text);
                    //CounterList[OStree.SelectedNode.Index].SetSystemTickCounter(SystemTickCounter.Checked);
                }
                else
                {
                    try
                    {
                        DisableCounterEvents();
                        SELECT_TIMER.Text = CounterList[OStree.SelectedNode.Index].GetTimerName();
                        MINCYCLE.Text = CounterList[OStree.SelectedNode.Index].GetMinCycle();
                        MAXALLOWEDVALUE.Text = CounterList[OStree.SelectedNode.Index].GetMaxAllowedValue();
                        TICKPERBASE.Text = CounterList[OStree.SelectedNode.Index].GetTickPerBase();
                        TIME_IN_NS.Text = CounterList[OStree.SelectedNode.Index].GetTimeInNS();
                        //SystemTickCounter.Checked = CounterList[OStree.SelectedNode.Index].GetSystemTickCounter();
                        EnableCounterEvents();
                    }
                    catch
                    {
                        MessageBox.Show("Problem with loading information for counter in form");
                    }
                }

            }

        }
        private void SELECT_TIMER_TextChanged(object sender, System.EventArgs e)
        { 
            ManageCounterValues(true);
        }
        private void MINCYCLE_TextChanged(object sender, System.EventArgs e)
        { 
            ManageCounterValues(true);
        }
        private void MAXALLOWEDVALUE_TextChanged(object sender, System.EventArgs e)
        { 
            ManageCounterValues(true);
        }
        private void TICKPERBASE_TextChanged(object sender, System.EventArgs e)
        { 
            ManageCounterValues(true);
        }
        private void TextChanged_TextChanged(object sender, System.EventArgs e)
        { 
            ManageCounterValues(true);
        }


		private void TaskType_TextChanged(object sender, System.EventArgs e)
		{
			ManageTskValues(true);
		}

		private void TaskPriority_TextChanged(object sender, System.EventArgs e)
		{
			ManageTskValues(true);
		}

		private void TaskActivation_TextChanged(object sender, System.EventArgs e)
		{
			ManageTskValues(true);
		}

		private void TaskSchedule_TextChanged(object sender, System.EventArgs e)
		{
			ManageTskValues(true);
		}

		private void TaskStackSize_TextChanged(object sender, System.EventArgs e)
		{
			ManageTskValues(true);
		}

		private void TskCallScheduler_TextChanged(object sender, System.EventArgs e)
		{
			ManageTskValues(true);
		}

		private void TaskEvent_TextChanged(object sender, System.EventArgs e)
		{
			ManageTskValues(true);
		}

		private void TaskResource_TextChanged(object sender, System.EventArgs e)
		{
			ManageTskValues(true);
		}
        private void COUNTER_SELECTOR_TextChanged(object sender, System.EventArgs e)
        {
            ManageAlarmValues(true);
        }
        private void AUTOSTART_ALARM_TIME_TextChanged(object sender, System.EventArgs e)
        {
            ManageAlarmValues(true);
        }
        private void ALARM_AUTOSTART_ENABLED_TextChanged(object sender, System.EventArgs e)
        {
            ManageAlarmValues(true);
        }
        private void CYCLE_TIME_VALUE_TextChanged(object sender, System.EventArgs e)
        {
            ManageAlarmValues(true);
        }
        private void Alarm_appmode_selector_TextChanged(object sender, System.EventArgs e)
        {
            ManageAlarmValues(true);
        }
        private void ALARM_ACTION_TextChanged(object sender, System.EventArgs e)
        {
            ManageAlarmValues(true);
        }
        private void AlarmToTask_TextChanged(object sender, System.EventArgs e)
        {
            ManageAlarmValues(true);
        }
        private void AlarmToEvent_TextChanged(object sender, System.EventArgs e)
        {
            ManageAlarmValues(true);
        }
        private void AlarmCallBack_TextChanged(object sender, System.EventArgs e)
        {
            ManageAlarmValues(true);
        }
        private void EnableCounterEvents()
        {

            this.SELECT_TIMER.SelectionChangeCommitted += new System.EventHandler(this.SELECT_TIMER_TextChanged);
            this.MINCYCLE.TextChanged += new System.EventHandler(this.MINCYCLE_TextChanged);
            this.MAXALLOWEDVALUE.TextChanged += new System.EventHandler(this.MAXALLOWEDVALUE_TextChanged);
            this.TICKPERBASE.TextChanged += new System.EventHandler(this.TICKPERBASE_TextChanged);
            this.TIME_IN_NS.TextChanged += new System.EventHandler(this.TextChanged_TextChanged);            

            this.OStree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseIsClick);
            this.OStree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.NewSelectedItem);
            this.OStree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.OStree_AfterLabelEdit);
        }
        private void DisableCounterEvents()
        {

            this.SELECT_TIMER.SelectionChangeCommitted -= new System.EventHandler(this.SELECT_TIMER_TextChanged);
            this.MINCYCLE.TextChanged -= new System.EventHandler(this.MINCYCLE_TextChanged);
            this.MAXALLOWEDVALUE.TextChanged -= new System.EventHandler(this.MAXALLOWEDVALUE_TextChanged);
            this.TICKPERBASE.TextChanged -= new System.EventHandler(this.TICKPERBASE_TextChanged);
            this.TIME_IN_NS.TextChanged -= new System.EventHandler(this.TextChanged_TextChanged);            

            this.OStree.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.MouseIsClick);
            this.OStree.AfterSelect -= new System.Windows.Forms.TreeViewEventHandler(this.NewSelectedItem);
            this.OStree.AfterLabelEdit -= new System.Windows.Forms.NodeLabelEditEventHandler(this.OStree_AfterLabelEdit);
        }
        private void EnableAlarmEvents()
		{

            this.COUNTER_SELECTOR.SelectionChangeCommitted += new System.EventHandler(this.COUNTER_SELECTOR_TextChanged);
			this.ALARM_AUTOSTART_ENABLED.CheckStateChanged += new System.EventHandler(this.ALARM_AUTOSTART_ENABLED_TextChanged);
            this.AUTOSTART_ALARM_TIME.TextChanged += new System.EventHandler(this.AUTOSTART_ALARM_TIME_TextChanged);
            this.CYCLE_TIME_VALUE.TextChanged += new System.EventHandler(this.CYCLE_TIME_VALUE_TextChanged);
            this.Alarm_appmode_selector.SelectionChangeCommitted += new System.EventHandler(this.Alarm_appmode_selector_TextChanged);
            this.ALARM_ACTION.SelectionChangeCommitted += new System.EventHandler(this.ALARM_ACTION_TextChanged);
            this.AlarmToTask.TextChanged += new System.EventHandler(this.AlarmToTask_TextChanged);
            this.AlarmToEvent.TextChanged += new System.EventHandler(this.AlarmToEvent_TextChanged);
            this.AlarmCallBack.TextChanged += new System.EventHandler(this.AlarmCallBack_TextChanged);



			this.OStree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseIsClick);
			this.OStree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.NewSelectedItem);
			this.OStree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.OStree_AfterLabelEdit);
		}
        private void DisableAlarmEvents()
        {

            this.COUNTER_SELECTOR.SelectionChangeCommitted -= new System.EventHandler(this.COUNTER_SELECTOR_TextChanged);
            this.ALARM_AUTOSTART_ENABLED.CheckStateChanged -= new System.EventHandler(this.ALARM_AUTOSTART_ENABLED_TextChanged);
            this.AUTOSTART_ALARM_TIME.TextChanged -= new System.EventHandler(this.AUTOSTART_ALARM_TIME_TextChanged);
            this.CYCLE_TIME_VALUE.TextChanged -= new System.EventHandler(this.CYCLE_TIME_VALUE_TextChanged);
            this.Alarm_appmode_selector.SelectionChangeCommitted -= new System.EventHandler(this.Alarm_appmode_selector_TextChanged);
            this.ALARM_ACTION.SelectionChangeCommitted -= new System.EventHandler(this.ALARM_ACTION_TextChanged);
            this.AlarmToTask.TextChanged -= new System.EventHandler(this.AlarmToTask_TextChanged);
            this.AlarmToEvent.TextChanged -= new System.EventHandler(this.AlarmToEvent_TextChanged);
            this.AlarmCallBack.TextChanged -= new System.EventHandler(this.AlarmCallBack_TextChanged);



            this.OStree.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.MouseIsClick);
            this.OStree.AfterSelect -= new System.Windows.Forms.TreeViewEventHandler(this.NewSelectedItem);
            this.OStree.AfterLabelEdit -= new System.Windows.Forms.NodeLabelEditEventHandler(this.OStree_AfterLabelEdit);
        }
		private void EnableTaskEvents()
		{
			this.TaskResource.SelectionChangeCommitted += new System.EventHandler(this.TaskResource_TextChanged);
			this.TskCallScheduler.SelectionChangeCommitted += new System.EventHandler(this.TskCallScheduler_TextChanged);
			this.TaskStackSize.TextChanged += new System.EventHandler(this.TaskStackSize_TextChanged);
			this.TaskSchedule.SelectionChangeCommitted += new System.EventHandler(this.TaskSchedule_TextChanged);
			this.TaskActivation.TextChanged += new System.EventHandler(this.TaskActivation_TextChanged);
			this.TaskType.SelectionChangeCommitted += new System.EventHandler(this.TaskType_TextChanged);
			this.TaskPriority.TextChanged += new System.EventHandler(this.TaskPriority_TextChanged);
			this.TaskEvent.SelectionChangeCommitted += new System.EventHandler(this.TaskEvent_TextChanged);			

			this.OStree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseIsClick);
			this.OStree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.NewSelectedItem);
			this.OStree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.OStree_AfterLabelEdit);
		}
        private void DisableTaskEvents()
        {
            this.TaskResource.SelectionChangeCommitted -= new System.EventHandler(this.TaskResource_TextChanged);
            this.TskCallScheduler.SelectionChangeCommitted -= new System.EventHandler(this.TskCallScheduler_TextChanged);
            this.TaskStackSize.TextChanged -= new System.EventHandler(this.TaskStackSize_TextChanged);
            this.TaskSchedule.SelectionChangeCommitted -= new System.EventHandler(this.TaskSchedule_TextChanged);
            this.TaskActivation.TextChanged -= new System.EventHandler(this.TaskActivation_TextChanged);
            this.TaskType.SelectionChangeCommitted -= new System.EventHandler(this.TaskType_TextChanged);
            this.TaskPriority.TextChanged -= new System.EventHandler(this.TaskPriority_TextChanged);
            this.TaskEvent.SelectionChangeCommitted -= new System.EventHandler(this.TaskEvent_TextChanged);

            this.OStree.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.MouseIsClick);
            this.OStree.AfterSelect -= new System.Windows.Forms.TreeViewEventHandler(this.NewSelectedItem);
            this.OStree.AfterLabelEdit -= new System.Windows.Forms.NodeLabelEditEventHandler(this.OStree_AfterLabelEdit);
        }
        
		private void OStree_AfterLabelEdit(object sender, System.Windows.Forms.NodeLabelEditEventArgs e)
		{
            
            if (null != OStree.SelectedNode.Parent)
            {
                
                if ((null == e.Label) || (e.Label.Length == 0))
                {                    
                    //MessageBox.Show("It is not allowed to have empty name for element");
                    e.CancelEdit = true;
                    return;
                }
                 
                if ("TASK" == OStree.SelectedNode.Parent.Text)
                {                                        
                   
                    {
                        TaskList[OStree.SelectedNode.Index].SetTaskName(e.Label);
                        TaskProperty.Text = TaskList[OStree.SelectedNode.Index].GetTaskName();
                        e.Node.EndEdit(false);
                    }
                    //TODO for alarms and Counters
                                     
                }

                else if ("ALARM" == OStree.SelectedNode.Parent.Text)
                {
                    AlarmList[OStree.SelectedNode.Index].SetAlarmName(e.Label);
                    e.Node.EndEdit(false);
                }
                else if ("COUNTER" == OStree.SelectedNode.Parent.Text)
                {
                    {
                        CounterList[OStree.SelectedNode.Index].SetCounterName(e.Label);
                        //CounterProperty.Text = CounterList[OStree.SelectedNode.Index].GetCounterName();
                        e.Node.EndEdit(false);
                    }

                   
                }
            }
		}
        private void GenerateMSP430ASM()
        { 
            string ResourceName = "NewOSEKGen." + "interrupts.s43";
            
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream(ResourceName);
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream(ResourceName));
            }
            catch
            {
                MessageBox.Show("Error accessing resources - interrupts.s43!");
            }
            // create a writer and open the file
            string format = "d/M/yyyy HH:mm:ss";
            TextWriter tw = new StreamWriter(PathToGenerate.Text + "interrupts.s43");
            GenerateASMHeader("interrupts.s43", "MSP430", tw);
            tw.WriteLine(";*******************************************************************************");
            tw.WriteLine(TrimARow(";* This file is genereted on: ", DateTime.Now.ToString(format), "**", 78));
            tw.WriteLine(";*                                                                            **");
            tw.WriteLine(";*******************************************************************************");
            tw.Write(_textStreamReader.ReadToEnd());
            tw.WriteLine("");

            tw.WriteLine(";------------------------------------------------------------------------------");
            tw.WriteLine(";			Interrupt Vectors");
            tw.WriteLine(";------------------------------------------------------------------------------");
            if ("MSP430F5438" == MicroSelection.SelectedItem)
            {
                tw.WriteLine("            .sect	\".int49\"    		    ;Timer_TA1CCR0 CCIFG0 Vector");
            }
            else if ("MSP430FG4618" == MicroSelection.SelectedItem)
            {
                tw.WriteLine("            .sect	\".int16\"    		    ;Timer_A0 Vector");
            }
             else
             {
                 MessageBox.Show("Problem - uC not recognized!");
                 //Exit(-1);
             }

             tw.WriteLine("            .short   OSEK_SYSTEM_TICK     ;");
             tw.WriteLine("            .end");
             tw.WriteLine("");
            tw.WriteLine(";***EOF***");
            // close the stream
            tw.Close();

        }
        private void GenerateUserTasks()
        {
            
           
            // create a writer and open the file
            string format = "d/M/yyyy HH:mm:ss";
            TextWriter tw = new StreamWriter(PathToGenerate.Text + "UserTasks.c");
            GenerateHeader("UserTasks.h", "MSP430", tw);
            tw.WriteLine("/*******************************************************************************");
            tw.WriteLine(TrimARow("** This file is genereted on: ", DateTime.Now.ToString(format), "**", 78));
            tw.WriteLine("**                                                                            **");
            tw.WriteLine("*******************************************************************************/");
            tw.WriteLine("#include \"Identification.h\"");
            tw.WriteLine("#if(MAGIC_NUMBER != " + MagicNumber.ToString() + ")");
            tw.WriteLine("    #error \"Inplausible genereted source files\"");
            tw.WriteLine("#endif /* (MAGIC_NUMBER != " + MagicNumber.ToString() + " */");
            tw.WriteLine("");
            tw.WriteLine("");
            
            if("MSP430F5438" == MicroSelection.SelectedItem)
            {
                tw.WriteLine("#include <msp430.h>");            
            }
            else if ("MSP430FG4618" == MicroSelection.SelectedItem)
            { 
                tw.WriteLine("#include <msp430xG46x.h>"); 
            }
            else
            { /*The next MSP$30 is here*/}
            
            tw.WriteLine("#include \"Task.h\"");            
            tw.WriteLine("#include \"MCU_HAL.h\"");
            tw.WriteLine("#include \"OS_cfg.h\"");
            for (int i = 0; i < TaskCounter; i++)
            {
                tw.WriteLine("/*****************************************************************************");
                tw.WriteLine(TrimARow(";* Task Name: ", TaskList[i].GetTaskName(), "**", 78));
                tw.WriteLine(" *****************************************************************************/");
                tw.WriteLine("");
                tw.WriteLine("void "+TaskList[i].GetTaskName()+"_code(void)");
                tw.WriteLine("{");
                tw.WriteLine("");
                tw.WriteLine("");
                if (TaskList[i].GetAutoStartTask())
                {
                    tw.WriteLine("/* This task is an autostart task. */");
                    tw.WriteLine("/* It will start automatically just after the system start */");
                }
                
                tw.WriteLine("/* Enter the task code HERE....*/");
                tw.WriteLine("/* TerminateTsk(); Task usually ends with termination*/");
                tw.WriteLine("    TerminateTsk();");
                tw.WriteLine("}");
                tw.WriteLine("");
            
            }
            tw.WriteLine("/*****************************************************************************");
            tw.WriteLine(TrimARow(";* Task Name: ", "Task_IDLE_code", "**", 78));
            tw.WriteLine(" *****************************************************************************/");
            tw.WriteLine("void Task_IDLE_code(void)");
            tw.WriteLine("{");
            tw.WriteLine("");
            tw.WriteLine("");
            tw.WriteLine("/* Enter the task code HERE....*/");
            tw.WriteLine("    while(1){/*...Or here*/}");
            tw.WriteLine("}");
            tw.WriteLine("");
            tw.WriteLine("");
            tw.WriteLine("/* EOF */");
            // close the stream
            tw.Close();
        }
        private void GenerateOSConf()
        {
            string ResourceName = "NewOSEKGen." + "OS_Cfg.h";
            int i, j, Counter = 0;
            AutoStartAlarmCounter = 0;
            AutostartTaskCounter = 0;
            string input = "";
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream(ResourceName);
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream(ResourceName));
            }
            catch
            {
                MessageBox.Show("Error accessing resources!");
            }
            // create a writer and open the file
            string format = "d/M/yyyy HH:mm:ss";
            TextWriter tw = new StreamWriter(PathToGenerate.Text + "OS_Cfg.h");
            GenerateHeader("OS_Cfg.h", "MSP430", tw);
            tw.WriteLine("/*******************************************************************************");
            tw.WriteLine(TrimARow("** This file is genereted on: ", DateTime.Now.ToString(format), "**", 78));
            tw.WriteLine("**                                                                            **");
            tw.WriteLine("*******************************************************************************/");
            
            tw.WriteLine("#if(MAGIC_NUMBER != " + MagicNumber.ToString() + ")");
            tw.WriteLine("    #error \"Inplausible genereted source files\"");
            tw.WriteLine("#endif /* (MAGIC_NUMBER != " + MagicNumber.ToString() + " */");


            tw.WriteLine(input);
            tw.WriteLine("#ifndef _OS_CFG_");
            tw.WriteLine("#define _OS_CFG_");
            tw.WriteLine(input);
            tw.WriteLine("#define DISABLE                         0");
            tw.WriteLine("#define ENABLE                          1");
            tw.WriteLine(input);
            tw.WriteLine("/** \brief ERROR_CHECKING_STANDARD */");
            tw.WriteLine("#define ERROR_CHECKING_STANDARD         1");

            tw.WriteLine("/** \brief ERROR_CHECKING_EXTENDED */");
            tw.WriteLine("#define ERROR_CHECKING_EXTENDED         2");
            tw.WriteLine(input);
            tw.WriteLine("/*****************************************************************************");
            tw.WriteLine(" *                     OS MODES OF OPERATION                                 *");
            tw.WriteLine(" *****************************************************************************/");
            tw.WriteLine("#define OS_NORMAL_MODE        0");
            tw.WriteLine("#define OS_NUMBER_OF_MODES    1");
            tw.WriteLine("/*****************************************************************************");
            tw.WriteLine(" *                        OS OBJECTS COUNT                                   *");
            tw.WriteLine(" *****************************************************************************/");
            tw.WriteLine("#define COUNTER_COUNT         " + CounterCount.ToString());
            tw.WriteLine("#define ALARMS_COUNT          " + AlarmCounter.ToString());
            tw.WriteLine("#define TASKS_COUNT           " + (TaskCounter+1).ToString()); // because of idle task
            for (i = 0; i < AlarmCounter; i++)
            {
                if ("TRUE" == AlarmList[i].GetAlarmAutostartEn())
                    AutoStartAlarmCounter++;
            }
            for (j = 0; j < CounterCount; j++)
            {
                for (i = 0; i < AlarmCounter; i++)
                {
                    if (CounterList[j].GetCounterName() == AlarmList[i].GetAlarmCounter())
                    {
                        Counter++;
                    }
                        
                }
                CounterList[j].SetAssociatedAlarms(Counter);
                tw.WriteLine("#define " + CounterList[j].GetCounterName() + "_ALARMS_COUNT        " + Counter.ToString());
                Counter = 0;
            }
            tw.WriteLine("#define ALARM_AUTOSTART_COUNT " + AutoStartAlarmCounter.ToString());
            for (i = 0; i < TaskCounter;i++ )
            {
                if (TaskList[i].GetAutoStartTask())
                {
                    AutostartTaskCounter++;
                }
            }
            tw.WriteLine("#define TASKS_AUTOSTART_COUNT " + (AutostartTaskCounter+1).ToString()); // +1 for idle task
            tw.WriteLine("#define READYLISTS_COUNT         TASKS_COUNT");
            tw.WriteLine("#define TASKS_MAX_NUMBER         TASKS_COUNT");
            
            tw.WriteLine(input);
            tw.WriteLine("/*****************************************************************************");
            tw.WriteLine(" *                            COUNTERS                                       *");
            tw.WriteLine(" *****************************************************************************/");
            for (i = 0; i < CounterCount; i++)
            {
                tw.WriteLine("#define " + CounterList[i].GetCounterName() + "    " + i.ToString());
                if ("TIMER_A" == CounterList[i].GetTimerName())
                {
                    CountersForTimer_A++;
                }
                if ("TIMER_B" == CounterList[i].GetTimerName())
                {
                    CountersForTimer_B++;
                }
            }
            if (CountersForTimer_A > 0)
                tw.WriteLine("#define COOUNTERS_FOR_TIMER_A    " + CountersForTimer_A.ToString());
            if (CountersForTimer_B > 0)
                tw.WriteLine("#define COOUNTERS_FOR_TIMER_B    " + CountersForTimer_B.ToString());
            tw.WriteLine("#define COUNTS_PER_TICK    " + CounterList[0].GetTickPerBase());
            tw.WriteLine("");
            tw.WriteLine("/*****************************************************************************");
            tw.WriteLine(" *                              ALARMS                                       *");
            tw.WriteLine(" *****************************************************************************/");
            for (i = 0; i < AlarmCounter; i++)
            { 
                tw.WriteLine("#define    "+AlarmList[i].GetAlarmName()+"    " + i.ToString());
            }
            tw.WriteLine("/*****************************************************************************");
            tw.WriteLine(" *                              TASKS                                        *");
            tw.WriteLine(" *****************************************************************************/");
            for (i = 0; i < TaskCounter; i++)
            {
                string a = "#define    " + TaskList[i].GetTaskName() +"   "+ i.ToString();              
                tw.WriteLine(a);               
            }
            tw.WriteLine("#define    Task_IDLE    " + i.ToString());           
            tw.WriteLine("/*****************************************************************************");
            tw.WriteLine(" *                        TASKS STACK SIZES                                  *");
            tw.WriteLine(" *****************************************************************************/");
            for (i = 0; i < TaskCounter; i++)
            {
                string a = "#define    " + "StackSizeTask" + i.ToString() + "    " + TaskList[i].GetTaskStackSize();
                tw.WriteLine(a);
            }
            tw.WriteLine("#define    SystemStackSize     256");
            tw.WriteLine("/*****************************************************************************");
            tw.WriteLine(" *                      GENERAL CONDITIONS                                   *");
            tw.WriteLine(" *****************************************************************************/");
            tw.WriteLine("#define     NO_EVENTS                       DISABLE");
            tw.WriteLine("/* The hooks and function at user disposal */\r\n");
            tw.WriteLine("#define ShutdownOs_Arch()");
            tw.WriteLine("#define ShutdownHook()");
            tw.WriteLine("#define EnableOSInterrupts()		_BIS_SR(GIE)");
            tw.WriteLine("#define SuspendAllInterrupts()");
            tw.WriteLine("#define IntSecure_Start()");
            tw.WriteLine("#define ResumeAllInterrupts()");
            tw.WriteLine("#define IntSecure_End()");
            tw.WriteLine("#define HOOK_ERRORHOOK                  DISABLE");
            tw.WriteLine("#define ERROR_CHECKING_TYPE             DISABLE");
            tw.WriteLine("#define HOOK_STARTUPHOOK				  ENABLE");
            tw.WriteLine("#define UART_INTERFACE				  ENABLE");
            tw.WriteLine("#define APPLICATION_MODE				(1)");
            tw.WriteLine("unsigned char rx_char;");
        
            


            tw.WriteLine("#endif /* _OS_CFG_ */");
            tw.WriteLine("");
            tw.WriteLine("/* EOF */");
            // close the stream
            tw.Close();
        }
        private void Generate_TMS_OSConf(string Path)
        {
            string ResourceName = "NewOSEKGen.Includes." + "OS_cfg.h";
            int i, j, Counter = 0;
            AutoStartAlarmCounter = 0;
            AutostartTaskCounter = 0;
            string input = "";
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream(ResourceName);
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream(ResourceName));
            }
            catch
            {
                MessageBox.Show("Error accessing resources!");
            }
            // create a writer and open the file
            string format = "d/M/yyyy HH:mm:ss";
            TextWriter tw = new StreamWriter(Path + "OS_Cfg.h");
            GenerateHeader("OS_Cfg.h", MicroSelection.SelectedItem.ToString(), tw);
            tw.WriteLine("/*******************************************************************************");
            tw.WriteLine(TrimARow("** This file is genereted on: ", DateTime.Now.ToString(format), "**", 78));
            tw.WriteLine("**                                                                            **");
            tw.WriteLine("*******************************************************************************/");

            tw.WriteLine("#if(MAGIC_NUMBER != " + MagicNumber.ToString() + ")");
            tw.WriteLine("    #error \"Inplausible genereted source files\"");
            tw.WriteLine("#endif /* (MAGIC_NUMBER != " + MagicNumber.ToString() + " */");


            tw.WriteLine(input);
            tw.WriteLine("#ifndef _OS_CFG_");
            tw.WriteLine("#define _OS_CFG_");
            tw.WriteLine(input);
            tw.WriteLine("#define DISABLE                         0");
            tw.WriteLine("#define ENABLE                          1");
            tw.WriteLine(input);
            tw.WriteLine("/** \brief ERROR_CHECKING_STANDARD */");
            tw.WriteLine("#define ERROR_CHECKING_STANDARD         1");

            tw.WriteLine("/** \brief ERROR_CHECKING_EXTENDED */");
            tw.WriteLine("#define ERROR_CHECKING_EXTENDED         2");
            tw.WriteLine(input);
            tw.WriteLine("/*****************************************************************************");
            tw.WriteLine(" *                     OS MODES OF OPERATION                                 *");
            tw.WriteLine(" *****************************************************************************/");
            tw.WriteLine("#define OS_NORMAL_MODE        0");
            tw.WriteLine("#define OS_NUMBER_OF_MODES    1");
            tw.WriteLine("/*****************************************************************************");
            tw.WriteLine(" *                        OS OBJECTS COUNT                                   *");
            tw.WriteLine(" *****************************************************************************/");
            tw.WriteLine("#define COUNTER_COUNT         " + CounterCount.ToString());
            tw.WriteLine("#define ALARMS_COUNT          " + AlarmCounter.ToString());
            tw.WriteLine("#define TASKS_COUNT           " + (TaskCounter + 1).ToString()); // because of idle task
            for (i = 0; i < AlarmCounter; i++)
            {
                if ("TRUE" == AlarmList[i].GetAlarmAutostartEn())
                    AutoStartAlarmCounter++;
            }
            for (j = 0; j < CounterCount; j++)
            {
                for (i = 0; i < AlarmCounter; i++)
                {
                    if (CounterList[j].GetCounterName() == AlarmList[i].GetAlarmCounter())
                    {
                        Counter++;
                    }

                }
                CounterList[j].SetAssociatedAlarms(Counter);
                tw.WriteLine("#define " + CounterList[j].GetCounterName() + "_ALARMS_COUNT        " + Counter.ToString());
                Counter = 0;
            }
            tw.WriteLine("#define ALARM_AUTOSTART_COUNT " + AutoStartAlarmCounter.ToString());
            for (i = 0; i < TaskCounter; i++)
            {
                if (TaskList[i].GetAutoStartTask())
                {
                    AutostartTaskCounter++;
                }
            }
            tw.WriteLine("#define TASKS_AUTOSTART_COUNT " + (AutostartTaskCounter + 1).ToString()); // +1 for idle task
            tw.WriteLine("#define READYLISTS_COUNT         TASKS_COUNT");
            tw.WriteLine("#define TASKS_MAX_NUMBER         TASKS_COUNT");

            tw.WriteLine(input);
            tw.WriteLine("/*****************************************************************************");
            tw.WriteLine(" *                            COUNTERS                                       *");
            tw.WriteLine(" *****************************************************************************/");
            for (i = 0; i < CounterCount; i++)
            {
                tw.WriteLine("#define " + CounterList[i].GetCounterName() + "    " + i.ToString());
                if ("TIMER_A" == CounterList[i].GetTimerName())
                {
                    CountersForTimer_A++;
                }
                if ("TIMER_B" == CounterList[i].GetTimerName())
                {
                    CountersForTimer_B++;
                }
            }
            if (CountersForTimer_A > 0)
                tw.WriteLine("#define COOUNTERS_FOR_TIMER_A    " + CountersForTimer_A.ToString());
            if (CountersForTimer_B > 0)
                tw.WriteLine("#define COOUNTERS_FOR_TIMER_B    " + CountersForTimer_B.ToString());
            tw.WriteLine("");
            tw.WriteLine("/*****************************************************************************");
            tw.WriteLine(" *                              ALARMS                                       *");
            tw.WriteLine(" *****************************************************************************/");
            for (i = 0; i < AlarmCounter; i++)
            {
                tw.WriteLine("#define    " + AlarmList[i].GetAlarmName() + "    " + i.ToString());
            }
            tw.WriteLine("/*****************************************************************************");
            tw.WriteLine(" *                              TASKS                                        *");
            tw.WriteLine(" *****************************************************************************/");
            for (i = 0; i < TaskCounter; i++)
            {
                string a = "#define    " + TaskList[i].GetTaskName() + "   " + i.ToString();
                tw.WriteLine(a);
            }
            tw.WriteLine("#define    Task_IDLE    " + i.ToString());
            tw.WriteLine("/*****************************************************************************");
            tw.WriteLine(" *                        TASKS STACK SIZES                                  *");
            tw.WriteLine(" *****************************************************************************/");
            for (i = 0; i < TaskCounter; i++)
            {
                string a = "#define    " + "StackSizeTask" + i.ToString() + "    " + TaskList[i].GetTaskStackSize();
                tw.WriteLine(a);
            }
            tw.WriteLine("#define    SystemStackSize     256");
            tw.WriteLine("/*****************************************************************************");
            tw.WriteLine(" *                      GENERAL CONDITIONS                                   *");
            tw.WriteLine(" *****************************************************************************/");
            tw.WriteLine("#define     NO_EVENTS                       DISABLE");
            tw.WriteLine("/* The hooks and function at user disposal */\r\n");
            tw.WriteLine("#define ShutdownOs_Arch()");
            tw.WriteLine("#define ShutdownHook()");
            tw.WriteLine("#define EnableOSInterrupts()		_BIS_SR(GIE)");
            tw.WriteLine("#define SuspendAllInterrupts()");
            tw.WriteLine("#define IntSecure_Start()");
            tw.WriteLine("#define ResumeAllInterrupts()");
            tw.WriteLine("#define IntSecure_End()");
            tw.WriteLine("#define HOOK_ERRORHOOK                  DISABLE");
            tw.WriteLine("#define ERROR_CHECKING_TYPE             DISABLE");
            tw.WriteLine("#define HOOK_STARTUPHOOK				  ENABLE");
            tw.WriteLine("#define UART_INTERFACE				  ENABLE");
            tw.WriteLine("#define APPLICATION_MODE				(1)");





            tw.WriteLine("#endif /* _OS_CFG_ */");
            tw.WriteLine("");
            tw.WriteLine("/* EOF */");
            // close the stream
            tw.Close();
        }
        private void GenerateTables()
        {
            string format = "d/M/yyyy HH:mm:ss";
            int i, j;            
            TextWriter tw = new StreamWriter(PathToGenerate.Text + "Tables.h");
            GenerateHeader("Tables.h", "MSP430", tw);
            tw.WriteLine("/*******************************************************************************");
            tw.WriteLine(TrimARow("** This file is genereted on: ", DateTime.Now.ToString(format), "**", 78));
            tw.WriteLine("**                                                                            **");
            tw.WriteLine("*******************************************************************************/");

            tw.WriteLine("#if(MAGIC_NUMBER != " + MagicNumber.ToString() + ")");
            tw.WriteLine("    #error \"Inplausible genereted source files\"");
            tw.WriteLine("#endif /* (MAGIC_NUMBER != " + MagicNumber.ToString() + " */");
            tw.WriteLine("#ifndef _TABLES_");
            tw.WriteLine("#define _TABLES_");
            tw.WriteLine("#include \"Counter.h\"");
            tw.WriteLine("#include \"OS_Cfg.h\"");
            tw.WriteLine("#include \"Alarm.h\"");
            tw.WriteLine("#include \"Task.h\"");
            tw.WriteLine("");
            for (i = 0; i < TaskCounter; i++)
            { 
                tw.WriteLine("extern void "+ TaskList[i].GetTaskName()+"_code(void);");
            }
            tw.WriteLine("extern void Task_IDLE_code(void);");
            tw.WriteLine("");                        
            for (i = 0; i < TaskCounter; i++)
            {
                tw.WriteLine("uint16 TaskStack" + i.ToString() + "[StackSizeTask" + i.ToString() + "];");
            }        
            tw.WriteLine("uint16 TaskIdleStack[64];");
            tw.WriteLine("volatile uint16 SystemStack[SystemStackSize];");
            tw.WriteLine("");
            tw.WriteLine("");
            tw.WriteLine("#define NOT_IMPLEMENTED 0");
            tw.WriteLine("AppModeType ApplicationMode;");
            if (CountersForTimer_A > 0)
            {
                tw.WriteLine("/******************************************************************************");
                tw.WriteLine(" *                         TIMER_A associated counters                        *");
                tw.WriteLine(" ******************************************************************************/");
                tw.WriteLine("CounterType Timer_A_Counters[COOUNTERS_FOR_TIMER_A]=");
                tw.WriteLine("{");
                tw.WriteLine("/* Counters connected to TIMER_A */");
                for (i = 0; i < CounterCount; i++)
                {
                    if ("TIMER_A" == CounterList[i].GetTimerName())
                    {
                        tw.WriteLine("    " + CounterList[i].GetCounterName() + ",");
                    }
                }

                tw.WriteLine("};");
                tw.WriteLine("");
            }
            if (CountersForTimer_B > 0)
            {
                tw.WriteLine("/******************************************************************************");
                tw.WriteLine(" *                         TIMER_B associated counters                        *");
                tw.WriteLine(" ******************************************************************************/");
                tw.WriteLine("CounterType Timer_B_Counters[COOUNTERS_FOR_TIMER_B]=");
                tw.WriteLine("{");
                tw.WriteLine("/* Counters connected to TIMER_B */");
                for (i = 0; i < CounterCount; i++)
                {
                    if ("TIMER_B" == CounterList[i].GetTimerName())
                    {
                        tw.WriteLine("    " + CounterList[i].GetCounterName() + ",");
                    }
                }

                tw.WriteLine("};");
                tw.WriteLine("");
            }
            
            tw.WriteLine("/******************************************************************************");
            tw.WriteLine(" *                         COUNTERS DATA                                      *");
            tw.WriteLine(" ******************************************************************************/");
            tw.WriteLine("");
            for (i = 0; i < CounterCount; i++)
            {
                if (CounterList[i].GetAssociatedAlarms() > 0)
                {
                    tw.WriteLine("/* these alarms have to be incremented with " + CounterList[i].GetCounterName() + "*/");
                    tw.WriteLine("const AlarmType " + CounterList[i].GetCounterName() + "_LIST[" + CounterList[i].GetCounterName() + "_ALARMS_COUNT]=");
                    tw.WriteLine("{");
                    for (j = 0; j < AlarmCounter; j++)
                    {
                        if (CounterList[i].GetCounterName() == AlarmList[j].GetAlarmCounter())
                        {
                            tw.WriteLine("   " + AlarmList[j].GetAlarmName() + ",");
                        }
                    }
                }
                tw.WriteLine("};");
            }
            tw.WriteLine("");
            tw.WriteLine("/******************************************************************************");
            tw.WriteLine(" *                Variable descriptors for the counters                       *");
            tw.WriteLine(" ******************************************************************************/");
            tw.WriteLine("CounterVarType CountersVar[COUNTER_COUNT]=");
            tw.WriteLine("{");
            for (i = 0; i < CounterCount; i++)
            {
                tw.WriteLine("    /* " + CounterList[i].GetCounterName() + " */");
                tw.WriteLine("    {0},");
            }
            tw.WriteLine("};");
            tw.WriteLine("");
            tw.WriteLine("/******************************************************************************");
            tw.WriteLine(" *                Constant descriptors for the counters                       *");
            tw.WriteLine(" ******************************************************************************/");
            tw.WriteLine("const CounterConstType CountersConst[COUNTER_COUNT]=");
            tw.WriteLine("{");
            for (i = 0; i < CounterCount; i++)
            {
                tw.WriteLine("    /* " + CounterList[i].GetCounterName() + " */");
                tw.WriteLine("    {");
                tw.WriteLine("        " + CounterList[i].GetCounterName() + "_ALARMS_COUNT, /* number of alarms associated with the counter*/");
                if(CounterList[i].GetAssociatedAlarms() > 0)
                    tw.WriteLine("        (AlarmType*)" + CounterList[i].GetCounterName() + "_LIST,");
                else
                    tw.WriteLine("        (AlarmType*)NULL, /*There are no alarms associated with this counter*/");
                tw.WriteLine("        " + CounterList[i].GetMaxAllowedValue() + ", /*  max allowed value */");
                tw.WriteLine("        " + CounterList[i].GetMinCycle() + ", /* min cycle */");
                tw.WriteLine("        " + CounterList[i].GetTickPerBase() + ", /*ticks per base */");
                tw.WriteLine("    },");
            }
            tw.WriteLine("};");
            tw.WriteLine("/******************************************************************************");
            tw.WriteLine(" *                Variable descriptors for the alarms                         *");
            tw.WriteLine(" ******************************************************************************/");
            tw.WriteLine("AlarmVarType AlarmsVar[ALARMS_COUNT]=");
            tw.WriteLine("{");
            for (i = 0; i < AlarmCounter; i++)
            {
                tw.WriteLine("    {");
                tw.WriteLine("        /* "+AlarmList[i].GetAlarmName() + " */");
                tw.WriteLine("        (AlarmStateType)0, /* Alarm state */");
                tw.WriteLine("        (AlarmTimeType)0, /* Alarm Time */");
                tw.WriteLine("        (AlarmCycleTimeType)0, /*Alarm Cyclic Time*/");
                tw.WriteLine("    },");
            }
            tw.WriteLine("};");
            tw.WriteLine("");
            tw.WriteLine("/******************************************************************************");
            tw.WriteLine(" *                Constant descriptors for the alarms                         *");
            tw.WriteLine(" ******************************************************************************/");
            tw.WriteLine("const AlarmConstType AlarmsConst[ALARMS_COUNT]=");
            tw.WriteLine("{");
            for (i = 0; i < AlarmCounter; i++)
            {
                tw.WriteLine("    /* " + AlarmList[i].GetAlarmName() + " */");
                tw.WriteLine("    " + AlarmList[i].GetAlarmCounter() + ", /* Associated Counter */");
                tw.WriteLine("    " + AlarmList[i].GetACTION_TYPE()+ ", /* Alarm action */");
                tw.WriteLine("    {");
                if ("ALARMCALLBACK" == AlarmList[i].GetACTION_TYPE())
                    tw.WriteLine("        " + AlarmList[i].GetALARMCALLBACK() + ", /* Callback to be executed */");
                else
                    tw.WriteLine("        (CallbackType )NULL, /* no callback */");   
                
                if ("ACTIVATETASK" == AlarmList[i].GetACTION_TYPE() || ("SETEVENT" == AlarmList[i].GetACTION_TYPE()))
                    tw.WriteLine("        " + AlarmList[i].GetTASK_NAME() + ", /* Task associated with the alarm */");
                else
                    tw.WriteLine("        INVALID_TASK, /* No Task is assiciated with the alarm */");
                tw.WriteLine("#if(0 != EVENT_ENABLED)");
                if ("SETEVENT" == AlarmList[i].GetACTION_TYPE())
                    tw.WriteLine("        "+ AlarmList[i].GetEVENT_NAME()+", /* Event to be triggered */");
                else
                    tw.WriteLine("        (EventMaskType)0, /* No Event is assiciated with the alarm */");
                tw.WriteLine("#endif /* (0 != EVENT_ENABLED) */");
                tw.WriteLine("        (AlarmType)0, /* Reserved field... */");
                tw.WriteLine("    },");

            }
            tw.WriteLine("};");
            if (AutoStartAlarmCounter > 0)
            {
                tw.WriteLine("/******************************************************************************");
                tw.WriteLine(" *             Constant descriptors for auto-start alarms                     *");
                tw.WriteLine(" ******************************************************************************/");
                tw.WriteLine("");
                tw.WriteLine("const AutoStartAlarmType AutoStartAlarm[ALARM_AUTOSTART_COUNT]=");
                tw.WriteLine("{");
                for (i = 0; i < AlarmCounter; i++)
                {
                    if ("TRUE" == AlarmList[i].GetAlarmAutostartEn())
                    {
                        tw.WriteLine("    /* "+AlarmList[i].GetAlarmName()+ " is set to autostart */");
                        tw.WriteLine("    {");
                        tw.WriteLine("         0, /* Active for this application mode */");
                        tw.WriteLine("         "+AlarmList[i].GetAlarmName()+", /* Alarm ID */");
                        tw.WriteLine("         " + AlarmList[i].GetAutostart_Alarmtime() + ", /* Alarm Time */");
                        tw.WriteLine("         " + AlarmList[i].GetAutostart_cycletime() + ", /* Cyclic Period */");

                        tw.WriteLine("    },");
                    }
                }
                tw.WriteLine("};");
            }
            tw.WriteLine("/******************************************************************************");
            tw.WriteLine(" *                Constant descriptors for the TASKS                          *");
            tw.WriteLine(" ******************************************************************************/");
            tw.WriteLine("const TaskConstType TasksConst[TASKS_COUNT] =");
            tw.WriteLine("{");
            SortTasks NewList = new SortTasks(TaskCounter, TaskList);
            for (i = 0; i < TaskCounter; i++)
            {
                tw.WriteLine("    /* "+TaskList[i].GetTaskName() + " */");
                tw.WriteLine("    {");
                tw.WriteLine("        "+TaskList[i].GetTaskName()+"_code, /* Task entry point */");
                tw.WriteLine("        (StackPtrType )&TaskStack" + i.ToString() + ", /* Pointer to Task's stack area*/");
                tw.WriteLine("        StackSizeTask" + i.ToString() + ", /* stack size */");
                tw.WriteLine("        " + NewList.GetPriority(i) + ", /*Task Priority (" + TaskList[i].GetTaskPrio() + ") */");
                tw.WriteLine("        "+TaskList[i].GetTaskTaskActivation()+", /* task max activations */");
                tw.WriteLine("        {");
                if(("BASIC" == TaskList[i].GetTaskType()))
                    tw.WriteLine("            0, /* BASIC Task */");
                else                 
                    tw.WriteLine("            1, /* EXTENDED Task */");
                if (("FULL" == TaskList[i].GetTaskScheduler()))
                    tw.WriteLine("            1, /* Pre-emptive Task */");
                else
                    tw.WriteLine("            0, /* NON Pre-emptive Task */");
                tw.WriteLine("            0, /* Task initial state - SUSPENDED */");
                tw.WriteLine("        },  /* task const flags */");
                if ("" == TaskList[i].GetTaskEvent())
                    tw.WriteLine("        (EventMaskType)0,/* Task's events mask */");
                else
                    tw.WriteLine("        (EventMaskType)" + TaskList[i].GetTaskEvent() + ", /* Task's events mask */");
                if("" == TaskList[i].GetTaskResource())
                    tw.WriteLine("        0,/* Task's resource mask */");
                else
                    tw.WriteLine("        " + TaskList[i].GetTaskResource() + ",/* Task's resource mask */");
                tw.WriteLine("    },");

            }
            tw.WriteLine("    /* Task_IDLE */");
            tw.WriteLine("    {");
            tw.WriteLine("        Task_IDLE_code, /* Task entry point */");
            tw.WriteLine("        (StackPtrType )&TaskIdleStack, /* Pointer to Task's stack area*/");
            tw.WriteLine("        64, /* stack size */");
            tw.WriteLine("        0, /* Idle task has lowest pirority in the system - 0 */");
            tw.WriteLine("        1, /* task max activations */");
            tw.WriteLine("        {");           
            tw.WriteLine("            0, /* BASIC Task */");                   
            tw.WriteLine("            1, /* Idle Task is always pre-emptive */");       
            tw.WriteLine("            0, /* Idle task initial state - SUSPENDED */");
            tw.WriteLine("        },  /* task const flags */");           
            tw.WriteLine("        (EventMaskType)0,/* No events for Idle Task */");
            tw.WriteLine("        0/* No Resources for Idle Task */");          
            tw.WriteLine("    }");          
            tw.WriteLine("};");
            tw.WriteLine("");
            tw.WriteLine("/******************************************************************************");
            tw.WriteLine(" *                Variable descriptors for the TASKS                          *");
            tw.WriteLine(" ******************************************************************************/");
            tw.WriteLine("TaskVariableType TasksVar[TASKS_COUNT]; /* Initialized during the start-up phase */");
            tw.WriteLine("");
            tw.WriteLine("/******************************************************************************");
            tw.WriteLine(" *                Static queue for tasks in READY state                       *");
            tw.WriteLine(" ******************************************************************************/");
            for (i = 0; i < TaskCounter+1; i++)
            {
                tw.WriteLine("TaskType ReadyList" + i.ToString() + "[1];");
            }
            tw.WriteLine("ReadyVarType ReadyVar[TASKS_COUNT]=");
            tw.WriteLine("{");
            for (i = 0; i < TaskCounter+1; i++)
            {
                tw.WriteLine("    {");
                tw.WriteLine("        0, /* List Start - empty */");
                tw.WriteLine("        0 /* List Count - empty */");
                tw.WriteLine("    },");
            }

            tw.WriteLine("};");
            tw.WriteLine("");
            tw.WriteLine("");
            tw.WriteLine("const ReadyConstType ReadyConst[TASKS_COUNT] =");
            tw.WriteLine("{");
            for (i = TaskCounter; i >= 0; i--)
            {
                tw.WriteLine("    {");
                tw.WriteLine("        1, /*  Length of this ready list */");
                tw.WriteLine("        ReadyList" + i.ToString() + ", /*  Pointer to the Ready List */");
                tw.WriteLine("    },");
            }
            tw.WriteLine("};");
            tw.WriteLine("");
            tw.WriteLine("");

            tw.WriteLine("/******************************************************************************");
            tw.WriteLine(" *           Constant descriptors for the auto-start TASKS                    *");
            tw.WriteLine(" ******************************************************************************/");
            tw.WriteLine("const TaskType AutoStartReadyList[TASKS_AUTOSTART_COUNT] = ");
            tw.WriteLine("{");
            for (i = 0; i < AutostartTaskCounter + 1; i++)
            {
                if(TaskList[i].GetAutoStartTask())
                    tw.WriteLine("    " + TaskList[i].GetTaskName()+",");
                
            }
            tw.WriteLine("    Task_IDLE");
            tw.WriteLine("};");            
            // The order of task in respect to their priority is not relevant
            // This is becasue they are going to be activated by ActivateTask()
            // which forms the ready queue!
            tw.WriteLine("const AutoStartType AutoStart[OS_NUMBER_OF_MODES] = ");
            tw.WriteLine("{");
            tw.WriteLine("    TASKS_AUTOSTART_COUNT,");
            tw.WriteLine("    AutoStartReadyList");
            tw.WriteLine("};");
            tw.WriteLine("");
            tw.WriteLine("");
            tw.WriteLine("#endif /* _TABLES_ */");
            tw.WriteLine("");
            tw.WriteLine("/* EOF */");
            // close the stream
            tw.Close();
        }
        private void Generate_OS_gen(string PathToBeGenerated)
        {
            string format = "d/M/yyyy HH:mm:ss";
            int i, j;
            TextWriter tw = new StreamWriter(PathToBeGenerated + "OS_gen.h");
            GenerateHeader("OS_gen.h", MicroSelection.SelectedItem.ToString(), tw);
            tw.WriteLine("/*******************************************************************************");
            tw.WriteLine(TrimARow("** This file is genereted on: ", DateTime.Now.ToString(format), "**", 78));
            tw.WriteLine("**                                                                            **");
            tw.WriteLine("*******************************************************************************/");

            tw.WriteLine("#if(MAGIC_NUMBER != " + MagicNumber.ToString() + ")");
            tw.WriteLine("    #error \"Inplausible genereted source files\"");
            tw.WriteLine("#endif /* (MAGIC_NUMBER != " + MagicNumber.ToString() + " */");
            tw.WriteLine("#ifndef OS_GEN_H_");
            tw.WriteLine("#define OS_GEN_H_");
            tw.WriteLine("#include \"Counter.h\"");
            tw.WriteLine("#include \"OS_Cfg.h\"");
            tw.WriteLine("#include \"Alarm.h\"");
            tw.WriteLine("#include \"Task.h\"");
            tw.WriteLine("");
            for (i = 0; i < TaskCounter; i++)
            {
                tw.WriteLine("extern void " + TaskList[i].GetTaskName() + "_code(void);");
            }
            tw.WriteLine("extern void Task_IDLE_code(void);");
            tw.WriteLine("");
            for (i = 0; i < TaskCounter; i++)
            {
                tw.WriteLine("uint16 TaskStack" + i.ToString() + "[StackSizeTask" + i.ToString() + "];");
            }
            tw.WriteLine("uint16 TaskIdleStack[64];");
            tw.WriteLine("volatile uint16 SystemStack[SystemStackSize];");
            tw.WriteLine("");
            tw.WriteLine("");
            if (CountersForTimer_A > 0)
            {
                tw.WriteLine("/******************************************************************************");
                tw.WriteLine(" *                         TIMER_A associated counters                        *");
                tw.WriteLine(" ******************************************************************************/");
                tw.WriteLine("CounterType Timer_A_Counters[COOUNTERS_FOR_TIMER_A]=");
                tw.WriteLine("{");
                tw.WriteLine("/* Counters connected to TIMER_A */");
                for (i = 0; i < CounterCount; i++)
                {
                    if ("TIMER_A" == CounterList[i].GetTimerName())
                    {
                        tw.WriteLine("    " + CounterList[i].GetCounterName() + ",");
                    }
                }

                tw.WriteLine("};");
                tw.WriteLine("");
            }
            if (CountersForTimer_B > 0)
            {
                tw.WriteLine("/******************************************************************************");
                tw.WriteLine(" *                         TIMER_B associated counters                        *");
                tw.WriteLine(" ******************************************************************************/");
                tw.WriteLine("CounterType Timer_B_Counters[COOUNTERS_FOR_TIMER_B]=");
                tw.WriteLine("{");
                tw.WriteLine("/* Counters connected to TIMER_B */");
                for (i = 0; i < CounterCount; i++)
                {
                    if ("TIMER_B" == CounterList[i].GetTimerName())
                    {
                        tw.WriteLine("    " + CounterList[i].GetCounterName() + ",");
                    }
                }

                tw.WriteLine("};");
                tw.WriteLine("");
            }

            tw.WriteLine("/******************************************************************************");
            tw.WriteLine(" *                         COUNTERS DATA                                      *");
            tw.WriteLine(" ******************************************************************************/");
            tw.WriteLine("");
            for (i = 0; i < CounterCount; i++)
            {
                if (CounterList[i].GetAssociatedAlarms() > 0)
                {
                    tw.WriteLine("/* these alarms have to be incremented with " + CounterList[i].GetCounterName() + "*/");
                    tw.WriteLine("const AlarmType " + CounterList[i].GetCounterName() + "_LIST[" + CounterList[i].GetCounterName() + "_ALARMS_COUNT]=");
                    tw.WriteLine("{");
                    for (j = 0; j < AlarmCounter; j++)
                    {
                        if (CounterList[i].GetCounterName() == AlarmList[j].GetAlarmCounter())
                        {
                            tw.WriteLine("   " + AlarmList[j].GetAlarmName() + ",");
                        }
                    }
                }
                tw.WriteLine("};");
            }
            tw.WriteLine("");
            tw.WriteLine("/******************************************************************************");
            tw.WriteLine(" *                Variable descriptors for the counters                       *");
            tw.WriteLine(" ******************************************************************************/");
            tw.WriteLine("CounterVarType CountersVar[COUNTER_COUNT]=");
            tw.WriteLine("{");
            for (i = 0; i < CounterCount; i++)
            {
                tw.WriteLine("    /* " + CounterList[i].GetCounterName() + " */");
                tw.WriteLine("    {0},");
            }
            tw.WriteLine("};");
            tw.WriteLine("");
            tw.WriteLine("/******************************************************************************");
            tw.WriteLine(" *                Constant descriptors for the counters                       *");
            tw.WriteLine(" ******************************************************************************/");
            tw.WriteLine("const CounterConstType CountersConst[COUNTER_COUNT]=");
            tw.WriteLine("{");
            for (i = 0; i < CounterCount; i++)
            {
                tw.WriteLine("    /* " + CounterList[i].GetCounterName() + " */");
                tw.WriteLine("    {");
                tw.WriteLine("        " + CounterList[i].GetCounterName() + "_ALARMS_COUNT, /* number of alarms associated with the counter*/");
                if (CounterList[i].GetAssociatedAlarms() > 0)
                    tw.WriteLine("        (AlarmType*)" + CounterList[i].GetCounterName() + "_LIST,");
                else
                    tw.WriteLine("        (AlarmType*)NULL, /*There are no alarms associated with this counter*/");
                tw.WriteLine("        " + CounterList[i].GetMaxAllowedValue() + ", /*  max allowed value */");
                tw.WriteLine("        " + CounterList[i].GetMinCycle() + ", /* min cycle */");
                tw.WriteLine("        " + CounterList[i].GetTickPerBase() + ", /*ticks per base */");
                tw.WriteLine("    },");
            }
            tw.WriteLine("};");
            tw.WriteLine("/******************************************************************************");
            tw.WriteLine(" *                Variable descriptors for the alarms                         *");
            tw.WriteLine(" ******************************************************************************/");
            tw.WriteLine("AlarmVarType AlarmsVar[ALARMS_COUNT]=");
            tw.WriteLine("{");
            for (i = 0; i < AlarmCounter; i++)
            {
                tw.WriteLine("    {");
                tw.WriteLine("        /* " + AlarmList[i].GetAlarmName() + " */");
                tw.WriteLine("        (AlarmStateType)0, /* Alarm state */");
                tw.WriteLine("        (AlarmTimeType)0, /* Alarm Time */");
                tw.WriteLine("        (AlarmCycleTimeType)0, /*Alarm Cyclic Time*/");
                tw.WriteLine("    },");
            }
            tw.WriteLine("};");
            tw.WriteLine("");
            tw.WriteLine("/******************************************************************************");
            tw.WriteLine(" *                Constant descriptors for the alarms                         *");
            tw.WriteLine(" ******************************************************************************/");
            tw.WriteLine("const AlarmConstType AlarmsConst[ALARMS_COUNT]=");
            tw.WriteLine("{");
            for (i = 0; i < AlarmCounter; i++)
            {
                tw.WriteLine("    /* " + AlarmList[i].GetAlarmName() + " */");
                tw.WriteLine("    " + AlarmList[i].GetAlarmCounter() + ", /* Associated Counter */");
                tw.WriteLine("    " + AlarmList[i].GetACTION_TYPE() + ", /* Alarm action */");
                tw.WriteLine("    {");
                if ("ALARMCALLBACK" == AlarmList[i].GetACTION_TYPE())
                    tw.WriteLine("        " + AlarmList[i].GetALARMCALLBACK() + ", /* Callback to be executed */");
                else
                    tw.WriteLine("        (CallbackType )NULL, /* no callback */");

                if ("ACTIVATETASK" == AlarmList[i].GetACTION_TYPE() || ("SETEVENT" == AlarmList[i].GetACTION_TYPE()))
                    tw.WriteLine("        " + AlarmList[i].GetTASK_NAME() + ", /* Task associated with the alarm */");
                else
                    tw.WriteLine("        INVALID_TASK, /* No Task is assiciated with the alarm */");
                tw.WriteLine("#if(0 != EVENT_ENABLED)");
                if ("SETEVENT" == AlarmList[i].GetACTION_TYPE())
                    tw.WriteLine("        " + AlarmList[i].GetEVENT_NAME() + ", /* Event to be triggered */");
                else
                    tw.WriteLine("        (EventMaskType)0, /* No Event is assiciated with the alarm */");
                tw.WriteLine("#endif /* (0 != EVENT_ENABLED) */");
                tw.WriteLine("        (AlarmType)0, /* Reserved field... */");
                tw.WriteLine("    },");

            }
            tw.WriteLine("};");
            if (AutoStartAlarmCounter > 0)
            {
                tw.WriteLine("/******************************************************************************");
                tw.WriteLine(" *             Constant descriptors for auto-start alarms                     *");
                tw.WriteLine(" ******************************************************************************/");
                tw.WriteLine("");
                tw.WriteLine("const AutoStartAlarmType AutoStartAlarm[ALARM_AUTOSTART_COUNT]=");
                tw.WriteLine("{");
                for (i = 0; i < AlarmCounter; i++)
                {
                    if ("TRUE" == AlarmList[i].GetAlarmAutostartEn())
                    {
                        tw.WriteLine("    /* " + AlarmList[i].GetAlarmName() + " is set to autostart */");
                        tw.WriteLine("    {");
                        tw.WriteLine("         0, /* Active for this application mode */");
                        tw.WriteLine("         " + AlarmList[i].GetAlarmName() + ", /* Alarm ID */");
                        tw.WriteLine("         " + AlarmList[i].GetAutostart_Alarmtime() + ", /* Alarm Time */");
                        tw.WriteLine("         " + AlarmList[i].GetAutostart_cycletime() + ", /* Cyclic Period */");

                        tw.WriteLine("    },");
                    }
                }
                tw.WriteLine("};");
            }
            tw.WriteLine("/******************************************************************************");
            tw.WriteLine(" *                Constant descriptors for the TASKS                          *");
            tw.WriteLine(" ******************************************************************************/");
            tw.WriteLine("const TaskConstType TasksConst[TASKS_COUNT] =");
            tw.WriteLine("{");
            SortTasks NewList = new SortTasks(TaskCounter, TaskList);
            for (i = 0; i < TaskCounter; i++)
            {
                tw.WriteLine("    /* " + TaskList[i].GetTaskName() + " */");
                tw.WriteLine("    {");
                tw.WriteLine("        " + TaskList[i].GetTaskName() + "_code, /* Task entry point */");
                tw.WriteLine("        (StackPtrType )&TaskStack" + i.ToString() + ", /* Pointer to Task's stack area*/");
                tw.WriteLine("        StackSizeTask" + i.ToString() + ", /* stack size */");
                tw.WriteLine("        " + NewList.GetPriority(i) + ", /*Task Priority (" + TaskList[i].GetTaskPrio() + ") */");
                tw.WriteLine("        " + TaskList[i].GetTaskTaskActivation() + ", /* task max activations */");
                tw.WriteLine("        {");
                if (("BASIC" == TaskList[i].GetTaskType()))
                    tw.WriteLine("            0, /* BASIC Task */");
                else
                    tw.WriteLine("            1, /* EXTENDED Task */");
                if (("FULL" == TaskList[i].GetTaskScheduler()))
                    tw.WriteLine("            1, /* Pre-emptive Task */");
                else
                    tw.WriteLine("            0, /* NON Pre-emptive Task */");
                tw.WriteLine("            0, /* Task initial state - SUSPENDED */");
                tw.WriteLine("        },  /* task const flags */");
                if ("" == TaskList[i].GetTaskEvent())
                    tw.WriteLine("        (EventMaskType)0,/* Task's events mask */");
                else
                    tw.WriteLine("        (EventMaskType)" + TaskList[i].GetTaskEvent() + ", /* Task's events mask */");
                if ("" == TaskList[i].GetTaskResource())
                    tw.WriteLine("        0,/* Task's resource mask */");
                else
                    tw.WriteLine("        " + TaskList[i].GetTaskResource() + ",/* Task's resource mask */");
                tw.WriteLine("    },");

            }
            tw.WriteLine("    /* Task_IDLE */");
            tw.WriteLine("    {");
            tw.WriteLine("        Task_IDLE_code, /* Task entry point */");
            tw.WriteLine("        (StackPtrType )&TaskIdleStack, /* Pointer to Task's stack area*/");
            tw.WriteLine("        64, /* stack size */");
            tw.WriteLine("        0, /* Idle task has lowest pirority in the system - 0 */");
            tw.WriteLine("        1, /* task max activations */");
            tw.WriteLine("        {");
            tw.WriteLine("            0, /* BASIC Task */");
            tw.WriteLine("            1, /* Idle Task is always pre-emptive */");
            tw.WriteLine("            0, /* Idle task initial state - SUSPENDED */");
            tw.WriteLine("        },  /* task const flags */");
            tw.WriteLine("        (EventMaskType)0,/* No events for Idle Task */");
            tw.WriteLine("        0/* No Resources for Idle Task */");
            tw.WriteLine("    }");
            tw.WriteLine("};");
            tw.WriteLine("");
            tw.WriteLine("/******************************************************************************");
            tw.WriteLine(" *                Variable descriptors for the TASKS                          *");
            tw.WriteLine(" ******************************************************************************/");
            tw.WriteLine("TaskVariableType TasksVar[TASKS_COUNT]; /* Initialized during the start-up phase */");
            tw.WriteLine("");
            tw.WriteLine("/******************************************************************************");
            tw.WriteLine(" *                Static queue for tasks in READY state                       *");
            tw.WriteLine(" ******************************************************************************/");
            for (i = 0; i < TaskCounter + 1; i++)
            {
                tw.WriteLine("TaskType ReadyList" + i.ToString() + "[1];");
            }
            tw.WriteLine("ReadyVarType ReadyVar[TASKS_COUNT]=");
            tw.WriteLine("{");
            for (i = 0; i < TaskCounter + 1; i++)
            {
                tw.WriteLine("    {");
                tw.WriteLine("        0, /* List Start - empty */");
                tw.WriteLine("        0 /* List Count - empty */");
                tw.WriteLine("    },");
            }

            tw.WriteLine("};");
            tw.WriteLine("");
            tw.WriteLine("");
            tw.WriteLine("const ReadyConstType ReadyConst[TASKS_COUNT] =");
            tw.WriteLine("{");
            for (i = TaskCounter; i >= 0; i--)
            {
                tw.WriteLine("    {");
                tw.WriteLine("        1, /*  Length of this ready list */");
                tw.WriteLine("        ReadyList" + i.ToString() + ", /*  Pointer to the Ready List */");
                tw.WriteLine("    },");
            }
            tw.WriteLine("};");
            tw.WriteLine("");
            tw.WriteLine("");

            tw.WriteLine("/******************************************************************************");
            tw.WriteLine(" *           Constant descriptors for the auto-start TASKS                    *");
            tw.WriteLine(" ******************************************************************************/");
            tw.WriteLine("const TaskType AutoStartReadyList[TASKS_AUTOSTART_COUNT] = ");
            tw.WriteLine("{");
            for (i = 0; i < AutostartTaskCounter + 1; i++)
            {
                if (TaskList[i].GetAutoStartTask())
                    tw.WriteLine("    " + TaskList[i].GetTaskName() + ",");

            }
            tw.WriteLine("    Task_IDLE");
            tw.WriteLine("};");
            // The order of task in respect to their priority is not relevant
            // This is becasue they are going to be activated by ActivateTask()
            // which forms the ready queue!
            tw.WriteLine("const AutoStartType AutoStart[OS_NUMBER_OF_MODES] = ");
            tw.WriteLine("{");
            tw.WriteLine("    TASKS_AUTOSTART_COUNT,");
            tw.WriteLine("    AutoStartReadyList");
            tw.WriteLine("};");
            tw.WriteLine("");
            tw.WriteLine("");
            tw.WriteLine("#endif /* OS_GEN_H_ */");
            tw.WriteLine("");
            tw.WriteLine("/* EOF */");
            // close the stream
            tw.Close();
        }
        // MouseOver_NewButton
        private void MouseOver_NewButton(object sender, System.EventArgs e)
		{
			toolTipNew.SetToolTip(NewFileButton,"New OIL");
		}

		private void MouseOver_OpenButton(object sender, System.EventArgs e)
		{
			toolTipNew.SetToolTip(OpenFileButton,"Open existing OIL");
		}

		private void MouseOver_SaveButton(object sender, System.EventArgs e)
		{
			toolTipNew.SetToolTip(SaveButton,"Save current configuration");
		}

		private void MouseOver_(object sender, System.EventArgs e)
		{
			toolTipNew.SetToolTip(ValidateIt,"Validate current project");
		}

		private void MouseOver_Generated(object sender, System.EventArgs e)
		{
			toolTipNew.SetToolTip(GenerateButton,"Generate OSEK");
		}

		private void MouseOver_StatisticsButton(object sender, System.EventArgs e)
		{
			toolTipNew.SetToolTip(StatisticsButton,"Check statistics");
		}

        private void PathButton_MouseHover(object sender, EventArgs e)
        {
            toolTipNew.SetToolTip(PathButton, "Set path for generated source files");
        }


		private void OpenFileButton_Click(object sender, System.EventArgs e)
		{   
			Stream myStream = null;
            
			OpenFileDialog openFileDialog1 = new OpenFileDialog();

			//openFileDialog1.InitialDirectory = "c:\\" ;
			openFileDialog1.Filter = "OSEK Implementation Language (*.oil)|*.OIL" ;
			openFileDialog1.FilterIndex = 2 ;
			openFileDialog1.RestoreDirectory = true ;

			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        { 
                            // Insert code to read the stream here.
                            
                            string file = openFileDialog1.FileName;
                            int j=0;
                            int counter;
                            try
                            {
                                
                                
                                
                                string text = File.ReadAllText(file);
                                string[] uCconf = text.Split(new string[] { "uC " }, StringSplitOptions.RemoveEmptyEntries);
                                string ucSelected = GetValueFromString(uCconf[0], "MICROCONTROLLER");
                                MicroSelection.SelectedIndex = Convert.ToInt32(ucSelected);
                                //MICROCONTROLLER- > ToolBar BE COMPLETED
                                // OS_CONF  ----------------------------------------------\
                                string[] osconf = text.Split(new string[] { "OS " }, StringSplitOptions.RemoveEmptyEntries);
                                string temp = GetValueFromString(osconf[1], "STACKCHECK");
                                if ("TRUE" == temp)
                                {
                                    STACK_CHECK_ENABLED.Checked = true;
                                }
                                else
                                {
                                    STACK_CHECK_ENABLED.Checked = false;
                                }
                                osconf[1] = osconf[1].Remove(0, (osconf[1].IndexOf('{') + 1));
                                osconf[1] = osconf[1].Remove(0, (osconf[1].IndexOf(';') + 1));
                                temp = GetValueFromString(osconf[1], "ERRORHOOK");
                                if ("TRUE" == temp)
                                {
                                    ERROR_CHECKING_EXTENDEDK_ENABLED.Checked = true;
                                }
                                else
                                {
                                    ERROR_CHECKING_EXTENDEDK_ENABLED.Checked = false;
                                }
                                osconf[1] = osconf[1].Remove(0, (osconf[1].IndexOf(';') + 1));
                                temp = GetValueFromString(osconf[1], "STARTUPHOOK");
                                
                                if ("TRUE" == temp)
                                {
                                    STARTUP_HOOK_ENABLED.Checked = true;
                                }
                                else
                                {
                                    STARTUP_HOOK_ENABLED.Checked = false;
                                }
                                osconf[1] = osconf[1].Remove(0, (osconf[1].IndexOf(';') + 1));
                                temp = GetValueFromString(osconf[1], "SHUTDOWNHOOK");
                                if ("TRUE" == temp)
                                {
                                    SHUTDOWN_HOOK_ENABLED.Checked = true;
                                }
                                else
                                {
                                    SHUTDOWN_HOOK_ENABLED.Checked = false;
                                }
                                osconf[1] = osconf[1].Remove(0, (osconf[1].IndexOf(';') + 1));
                                temp = GetValueFromString(osconf[1], "PRETASKHOOK");
                                if ("TRUE" == temp)
                                {
                                    PRETASK_HOOK_ENABLED.Checked = true;
                                }
                                else
                                {
                                    PRETASK_HOOK_ENABLED.Checked = false;
                                }
                                osconf[1] = osconf[1].Remove(0, (osconf[1].IndexOf(';') + 1));
                                temp = GetValueFromString(osconf[1], "POSTTASKHOOK");
                                if ("TRUE" == temp)
                                {
                                    POSTTASK_HOOK_ENABLED.Checked = true;
                                }
                                else
                                {
                                    POSTTASK_HOOK_ENABLED.Checked = false;
                                }
                                osconf[1] = osconf[1].Remove(0, (osconf[1].IndexOf(';') + 1));
                                temp = GetValueFromString(osconf[1], "PREISRHOOK");
                                if ("TRUE" == temp)
                                {
                                    PREISR_HOOK_ENABLED.Checked = true;
                                }
                                else
                                {
                                    PREISR_HOOK_ENABLED.Checked = false;
                                }
                                osconf[1] = osconf[1].Remove(0, (osconf[1].IndexOf(';') + 1));
                                temp = GetValueFromString(osconf[1], "POSTISRHOOK");
                                if ("TRUE" == temp)
                                {
                                    POSTISR_HOOK_ENABLED.Checked = true;
                                }
                                else
                                {
                                    POSTISR_HOOK_ENABLED.Checked = false;
                                }
                                osconf[1] = osconf[1].Remove(0, (osconf[1].IndexOf(';') + 1));
                                temp = GetValueFromString(osconf[1], "INTERRUPTNESTING");
                                if ("TRUE" == temp)
                                {
                                    Enabled_ISR_Nesting.Checked = true;
                                }
                                else
                                {
                                    Enabled_ISR_Nesting.Checked = false;
                                }
                                osconf[1] = osconf[1].Remove(0, (osconf[1].IndexOf(';') + 1));
                                // COUNTERS ----------------------------------------------\
                                string[] cnt = text.Split(new string[] { "COUNTER " }, StringSplitOptions.RemoveEmptyEntries);                               
                                CounterCount = cnt.Length;
                                // remove the fake rows
                                for (int i = 0; i < CounterCount; i++)
                                {
                                    if (cnt[i].Contains("TIMER ="))
                                    {
                                        if (CounterList[j] == null)
                                        {
                                            CounterList[j] = new Counter();
                                        }
                                        CounterList[j].SetCounterName(GetNameOfObject(cnt[i]));
                                        cnt[i] = cnt[i].Remove(0, (cnt[i].IndexOf('{') + 1));
                                        CounterList[j].SetTimerName(GetValueFromString(cnt[i], "TIMER"));
                                        cnt[i] = cnt[i].Remove(0, (cnt[i].IndexOf(';') + 1));
                                        CounterList[j].SetMinCycle(GetValueFromString(cnt[i], "MINCYCLE"));
                                        cnt[i] = cnt[i].Remove(0, (cnt[i].IndexOf(';') + 1));
                                        CounterList[j].SetMaxAllowedValue(GetValueFromString(cnt[i], "MAXALLOWEDVALUE"));
                                        cnt[i] = cnt[i].Remove(0, (cnt[i].IndexOf(';') + 1));
                                        CounterList[j].SetTickPerBase(GetValueFromString(cnt[i], "TICKPERBASE"));
                                        cnt[i] = cnt[i].Remove(0, (cnt[i].IndexOf(';') + 1));
                                        CounterList[j].SetTimeInNS(GetValueFromString(cnt[i], "TIME_IN_NS"));
                                        cnt[i] = cnt[i].Remove(0, (cnt[i].IndexOf(';') + 1));
                                        j++;
                                    }
                                }
                                CounterCount = j;
                                this.OStree.SelectedNode = this.OStree.Nodes[0].Nodes[3];  
                                if (this.OStree.SelectedNode.Nodes != null)
                                {
                                    this.OStree.SelectedNode.Nodes.Clear();
                                }
                                counter = 0;
                                while (CounterList[counter] != null)
                                {
                                    this.OStree.SelectedNode.Nodes.Add(CounterList[counter].GetCounterName());
                                    counter++;
                                }
                                COUNTER_SELECTOR.Items.Clear();
                                for (int i = 0; i < CounterCount; i++)
                                {
                                    COUNTER_SELECTOR.Items.Add(CounterList[i].GetCounterName());
                                }
                                // ALARMS---------------------------------------------------
                                string[] res = text.Split(new string[] { "ALARM " }, StringSplitOptions.None);
                                AlarmCounter = res.Length - 1;
                                for (int i = 0; i < AlarmCounter; i++)
                                {
                                    if (AlarmList[i] == null)
                                    {
                                        AlarmList[i] = new Alarm();
                                    }
                                    AlarmList[i].SetAlarmName(GetNameOfObject(res[i + 1]));

                                    AlarmList[i].SetAlarmCounter(GetValueFromString(res[i + 1], "COUNTER"));
                                    res[i + 1] = res[i + 1].Remove(0, (res[i + 1].IndexOf(';') + 1));
                                    string AlarmAction = GetValueFromString(res[i + 1], "ACTION");
                                    AlarmList[i].SetACTION_TYPE(AlarmAction);
                                    res[i + 1] = res[i + 1].Remove(0, (res[i + 1].IndexOf('{') + 1));
                                    if ("ACTIVATETASK" == AlarmAction)
                                    {
                                        AlarmList[i].SetTASK_NAME(GetValueFromString(res[i + 1], "TASK"));
                                    }
                                    else if ("SETEVENT" == AlarmAction)
                                    {
                                        AlarmList[i].SetEVENT_NAME(GetValueFromString(res[i + 1], "EVENT"));
                                    }
                                    else if ("ALARMCALLBACK" == AlarmAction)
                                    {
                                        AlarmList[i].SetALARMCALLBACK(GetValueFromString(res[i + 1], "CALLBACK"));
                                    }
                                    else
                                    {
                                        MessageBox.Show(NameOfSystem, "Not correct OIL File!");
                                    }
                                    res[i + 1] = res[i + 1].Remove(0, (res[i + 1].IndexOf('}') + 1));
                                    res[i + 1] = res[i + 1].Remove(0, (res[i + 1].IndexOf(';') + 1));
                                    AlarmList[i].SetAlarmAutostartEn(GetValueFromString(res[i + 1], "AUTOSTART"));
                                    res[i + 1] = res[i + 1].Remove(0, (res[i + 1].IndexOf('{') + 1));
                                    AlarmList[i].SetAutostart_Alarmtime(GetValueFromString(res[i + 1], "ALARMTIME"));
                                    res[i + 1] = res[i + 1].Remove(0, (res[i + 1].IndexOf(';') + 1));
                                    AlarmList[i].SetAutostart_cycletime(GetValueFromString(res[i + 1], "CYCLETIME"));
                                    
                                      
                                }
                                this.OStree.SelectedNode = this.OStree.Nodes[0].Nodes[5];
                                if (this.OStree.SelectedNode.Nodes != null)
                                {
                                    this.OStree.SelectedNode.Nodes.Clear();
                                }
                                counter = 0;
                                while (AlarmList[counter] != null)
                                {
                                    this.OStree.SelectedNode.Nodes.Add(AlarmList[counter].GetAlarmName());
                                    counter++;
                                }
                                // TASKS --------------------------------------------------------------------
                                j = 0;
                                string[] tsk = text.Split(new string[] { "TASK " }, StringSplitOptions.None);
                                TaskCounter = tsk.Length - 1;
                                for (int i = 0; i < TaskCounter; i++)
                                {
                                    if (tsk[i].Contains("PRIORITY ="))
                                    {
                                        if (TaskList[j] == null)
                                        {
                                            TaskList[j] = new Task();
                                        }
                                        TaskList[j].SetTaskName(GetNameOfObject(tsk[i]));
                                        tsk[i] = tsk[i].Remove(0, (tsk[i].IndexOf('{') + 1));
                                        TaskList[j].SetTaskType(GetValueFromString(tsk[i], "TYPE"));
                                        tsk[i] = tsk[i].Remove(0, (tsk[i].IndexOf(';') + 1));
                                        TaskList[j].SetTaskPrio(GetValueFromString(tsk[i], "PRIORITY"));
                                        tsk[i] = tsk[i].Remove(0, (tsk[i].IndexOf(';') + 1));
                                        TaskList[j].SetTaskActivation(GetValueFromString(tsk[i], "ACTIVATION"));
                                        tsk[i] = tsk[i].Remove(0, (tsk[i].IndexOf(';') + 1));
                                        TaskList[j].SetTaskScheduler(GetValueFromString(tsk[i], "SCHEDULE"));
                                        tsk[i] = tsk[i].Remove(0, (tsk[i].IndexOf(';') + 1));
                                        TaskList[j].SetTaskCallScheduler(GetValueFromString(tsk[i], "CALLSCHEDULER"));
                                        tsk[i] = tsk[i].Remove(0, (tsk[i].IndexOf(';') + 1));
                                        TaskList[j].SetTaskStackSize(GetValueFromString(tsk[i], "STACKSIZE"));
                                        tsk[i] = tsk[i].Remove(0, (tsk[i].IndexOf(';') + 1));
                                        TaskList[j].SetTaskEvent(GetValueFromString(tsk[i], "EVENT"));
                                        tsk[i] = tsk[i].Remove(0, (tsk[i].IndexOf(';') + 1));
                                        TaskList[j].SetTaskResource(GetValueFromString(tsk[i], "RESOURCE"));
                                        tsk[i] = tsk[i].Remove(0, (tsk[i].IndexOf(';') + 1));
                                        TaskList[j].SetAutoStartTask(GetValueFromString(tsk[i], "AUTOSTART").Contains("TRUE"));
                                        tsk[i] = tsk[i].Remove(0, (tsk[i].IndexOf(';') + 1));
                                        j++;
                                    }
                                }
                                TaskCounter = j;
                                this.OStree.SelectedNode = this.OStree.Nodes[0].Nodes[1];                                  
                                if (this.OStree.SelectedNode.Nodes != null)
                                {
                                    this.OStree.SelectedNode.Nodes.Clear();
                                }
                                counter = 0;
                                while (TaskList[counter] != null)
                                {
                                    this.OStree.SelectedNode.Nodes.Add(TaskList[counter].GetTaskName());
                                    counter++;
                                }
                                  
                                
                                OStree.Enabled = true;
			                    OStree.Visible = true;
			                    SaveButton.Enabled = true;
                                tabControl.Visible = true;
                                tabControl.Enabled = true;
                                ValidateIt.Enabled = true;
                                GenerateButton.Enabled = true;
                            }
                            catch (IOException)
                            {
                            }
                        
                        }
                    }

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}
            StatisticsButton.Enabled = true;
		}
        private string GetNameOfObject(string p)
        {
            int end = p.IndexOf("\r\n");
            return p.Substring(0, end); 
        }
        private string GetValueFromString(string InputString, string token)
        {
            if ((null != InputString) && (null != token))
            {
                try 
                {
                    //string[] res = InputString.Split(token, StringSplitOptions.None);
                    int Inx = InputString.IndexOf(token);
                    int endInx = Inx+ token.Length;
                    int Point = InputString.IndexOf(';', Inx);
                    string Result = InputString.Substring(endInx, (Point - endInx));
                    Result = Result.Replace(" ", "");
                    Result = Result.Replace("=", "");
                    return Result;
                }
                catch (IOException)
                {
                }
                return token;
            }
            else
            {
                MessageBox.Show(NameOfSystem, "Internal error - string is empty!");
                return("");
            }
        }
		private void NewFileButton_Click(object sender, System.EventArgs e)
		{
			OStree.Enabled = true;
			OStree.Visible = true;
			SaveButton.Enabled = true;
            tabControl.Visible = true;
            tabControl.Enabled = true;
			
		}
        private void InitVars()
        {
            MagicNumber = 0;
            CountersForTimer_A = 0;
            CountersForTimer_B = 0;
            AutoStartAlarmCounter = 0;
            AutostartTaskCounter = 0;
            
        }
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
            
			ValidateIt.Enabled = true;
			GenerateButton.Enabled = true;
			StatisticsButton.Enabled = true;

            writeToFileSaveFileDialog.Title = "Specify Destination OSEK Configuration File";
            writeToFileSaveFileDialog.Filter = "Text Files|*.oil";
            writeToFileSaveFileDialog.FilterIndex = 1;
            writeToFileSaveFileDialog.OverwritePrompt = true;
           

            if (writeToFileSaveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                // create a file stream, where "c:\\testing.txt" is the file path
                System.IO.FileStream fs = new System.IO.FileStream(writeToFileSaveFileDialog.FileName, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);

                // create a stream writer
                System.IO.StreamWriter sw = new System.IO.StreamWriter(fs, System.Text.Encoding.ASCII);
                //*************************************************************************
                //                                  Microcontroller
                //*************************************************************************
                sw.WriteLine("uC {");
                sw.WriteLine("    MICROCONTROLLER = " + MicroSelection.SelectedIndex.ToString() + ";");
                sw.WriteLine("};");
                //*************************************************************************
                //                                        OS
                //*************************************************************************
                sw.WriteLine("OS {");
                sw.WriteLine("    BOOLEAN STACKCHECK = " + OS_FORM.GetSTACK_CHECK() + ";");
                
                sw.WriteLine("    BOOLEAN ERRORHOOK = " + OS_FORM.GetERROR_CHECKING_EXTENDED() + ";");
                sw.WriteLine("    BOOLEAN STARTUPHOOK = "+ OS_FORM.GetSTARTUP_HOOK()+";");
                sw.WriteLine("    BOOLEAN SHUTDOWNHOOK = " + OS_FORM.GetSHUTDOWN_HOOK() + ";");
                sw.WriteLine("    BOOLEAN PRETASKHOOK = " + OS_FORM.GetPRETASK_HOOK() + ";");
                sw.WriteLine("    BOOLEAN POSTTASKHOOK = " + OS_FORM.GetPOSTISR_HOOK() + ";");
                
                sw.WriteLine("    BOOLEAN PREISRHOOK = " + OS_FORM.GetPREISR_HOOK() + ";");
                sw.WriteLine("    BOOLEAN POSTISRHOOK = " + OS_FORM.GetPOSTISR_HOOK() + ";");
                sw.WriteLine("    BOOLEAN INTERRUPTNESTING = " + OS_FORM.GetINTERRUPT_NESTING() + ";");
                sw.WriteLine("};");

                //*************************************************************************
                //                                 TASKS
                //*************************************************************************



                for(int i=0; i<TaskCounter; i++)
                {
                    sw.WriteLine("TASK "+TaskList[i].GetTaskName());
                    sw.WriteLine("{");
                    sw.WriteLine("    TYPE = "+TaskList[i].GetTaskType()+";");
                    sw.WriteLine("    PRIORITY = " + TaskList[i].GetTaskPrio() + ";");
                    sw.WriteLine("    ACTIVATION = " + TaskList[i].GetTaskTaskActivation() + ";");
                    sw.WriteLine("    SCHEDULE = " + TaskList[i].GetTaskScheduler() + ";");
                    sw.WriteLine("    CALLSCHEDULER = " + TaskList[i].GetTaskCallScheduler() + ";");
                    sw.WriteLine("    STACKSIZE = " + TaskList[i].GetTaskStackSize() + ";");
                    sw.WriteLine("    EVENT = " + TaskList[i].GetTaskEvent() + ";");
                    sw.WriteLine("    RESOURCE = " + TaskList[i].GetTaskEvent() + ";");                    
                    sw.WriteLine("    AUTOSTART = " + TaskList[i].GetAutoStartTask().ToString().ToUpper() + ";");
                    sw.WriteLine("};");
                    
                }
                for (int i = 0; i < CounterCount; i++)
                {
                    sw.WriteLine("COUNTER " + CounterList[i].GetCounterName());
                    sw.WriteLine("{");
                    sw.WriteLine("    TIMER = " + CounterList[i].GetTimerName() + ";");
                    sw.WriteLine("    MINCYCLE = " + CounterList[i].GetMinCycle() + ";");
                    sw.WriteLine("    MAXALLOWEDVALUE = " + CounterList[i].GetMaxAllowedValue() + ";");
                    sw.WriteLine("    TICKPERBASE = " + CounterList[i].GetTickPerBase() + ";");
                    sw.WriteLine("    TIME_IN_NS = " + CounterList[i].GetTimeInNS() + ";");
                    sw.WriteLine("};");
                    
                }
                for (int i = 0; i < AlarmCounter; i++)
                {
                    sw.WriteLine("ALARM " + AlarmList[i].GetAlarmName());
                    sw.WriteLine("{");
                    sw.WriteLine("    COUNTER = " + AlarmList[i].GetAlarmCounter() + ";");
                    sw.WriteLine("    ACTION = " + AlarmList[i].GetACTION_TYPE() + ";");
                    sw.WriteLine("        {");
                    if (AlarmList[i].GetACTION_TYPE() == "ACTIVATETASK")
                    {
                        sw.WriteLine("            TASK = " + AlarmList[i].GetTASK_NAME() + ";");
                    }
                    else if (AlarmList[i].GetACTION_TYPE() == "SETEVENT")
                    {
                        sw.WriteLine("            TASK = " + AlarmList[i].GetTASK_NAME() + ";");
                        sw.WriteLine("            EVENT = " + AlarmList[i].GetEVENT_NAME() + ";");
                    }
                    else if (AlarmList[i].GetACTION_TYPE() == "ALARMCALLBACK")
                    {
                        sw.WriteLine("            CALLBACK = " + AlarmList[i].GetALARMCALLBACK() + ";");
                    }
                    sw.WriteLine("        };");
                    sw.WriteLine("    AUTOSTART = " + AlarmList[i].GetAlarmAutostartEn().ToUpper() + ";");
                    sw.WriteLine("        {");
                    sw.WriteLine("            ALARMTIME = " + AlarmList[i].GetAutostart_Alarmtime() + ";");
                    sw.WriteLine("            CYCLETIME = " + AlarmList[i].GetAutostart_cycletime() + ";");
                    sw.WriteLine("        };");
                    sw.WriteLine("};");
                }
                // flush buffer (so the text really goes into the file)
                sw.Flush();

                // close stream writer and file
                sw.Close(); 
                fs.Close();

            }

		
		}
            private int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max); 
            }
        private void GenerateFile(string FileName,  int MagicNumber)
        {
            
            string ResourceName = "NewOSEKGen." + FileName;
            
            
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream(ResourceName);
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream(ResourceName));
            }
            catch
            {
                MessageBox.Show("Error accessing resources!");
            }
            // create a writer and open the file
            string format = "d/M/yyyy HH:mm:ss";
            TextWriter tw = new StreamWriter(PathToGenerate.Text + FileName);
            GenerateHeader(FileName, MicroSelection.SelectedItem.ToString(), tw);
            tw.WriteLine("/*******************************************************************************");
            tw.WriteLine(TrimARow("** This file is genereted on: ", DateTime.Now.ToString(format), "**", 78));
            tw.WriteLine("**                                                                            **");
            tw.WriteLine("*******************************************************************************/");
             tw.WriteLine("#include \"Identification.h\"");
            tw.WriteLine("#if(MAGIC_NUMBER != " + MagicNumber.ToString() + ")");
            tw.WriteLine("    #error \"Inplausible genereted source files\"");
            tw.WriteLine("#endif /* (MAGIC_NUMBER != " + MagicNumber.ToString() + " */");
            tw.Write(_textStreamReader.ReadToEnd());
            tw.WriteLine("");
            tw.WriteLine("/* EOF */");

            // close the stream
            tw.Close();
        }
        private void GenerateTMS_ASM_File(string FileName, int MagicNumber, string ResourceFolder,string DSTPath)
        {

            string ResourceName = "NewOSEKGen." + ResourceFolder + FileName;


            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream(ResourceName);
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream(ResourceName));
            }
            catch
            {
                MessageBox.Show("Error accessing resources!");
            }
            // create a writer and open the file
            string format = "d/M/yyyy HH:mm:ss";
            TextWriter tw = new StreamWriter(DSTPath + FileName);
            GenerateHeader_asm(FileName, MicroSelection.SelectedItem.ToString(), tw);
            tw.WriteLine(";/*******************************************************************************");
            tw.WriteLine(TrimARow(";** This file is genereted on: ", DateTime.Now.ToString(format), "**", 78));
            tw.WriteLine(";**                                                                            **");
            tw.WriteLine(";*******************************************************************************/");
            
            
            tw.Write(_textStreamReader.ReadToEnd());
            tw.WriteLine("");
            tw.WriteLine(";/* EOF */");

            // close the stream
            tw.Close();
        }
        private void GenerateTMSFile(string FileName, int MagicNumber, string ResourceFolder, string DSTPath)
        {

            string ResourceName = "NewOSEKGen." + ResourceFolder + FileName;


            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream(ResourceName);
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream(ResourceName));
            }
            catch
            {
                MessageBox.Show("Error accessing resources!");
            }
            // create a writer and open the file
            string format = "d/M/yyyy HH:mm:ss";
            TextWriter tw = new StreamWriter(DSTPath + FileName);
            GenerateHeader(FileName, MicroSelection.SelectedItem.ToString(), tw);
            tw.WriteLine("/*******************************************************************************");
            tw.WriteLine(TrimARow("** This file is genereted on: ", DateTime.Now.ToString(format), "**", 78));
            tw.WriteLine("**                                                                            **");
            tw.WriteLine("*******************************************************************************/");
            tw.WriteLine("#include \"Identification.h\"");
            tw.WriteLine("#if(MAGIC_NUMBER != " + MagicNumber.ToString() + ")");
            tw.WriteLine("    #error \"Inplausible genereted source files\"");
            tw.WriteLine("#endif /* (MAGIC_NUMBER != " + MagicNumber.ToString() + " */");
            tw.Write(_textStreamReader.ReadToEnd());
            tw.WriteLine("");
            tw.WriteLine("/* EOF */");

            // close the stream
            tw.Close();
        }
        private void GenerateTMS_UserTasks(string FileName, int MagicNumber, string ResourceFolder, string DSTPath)
        {

            string ResourceName = "NewOSEKGen." + ResourceFolder + FileName;


            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream(ResourceName);
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream(ResourceName));
            }
            catch
            {
                MessageBox.Show("Error accessing resources!");
            }
            // create a writer and open the file
            string format = "d/M/yyyy HH:mm:ss";
            TextWriter tw = new StreamWriter(DSTPath + FileName);
            GenerateHeader(FileName, MicroSelection.SelectedItem.ToString(), tw);
            tw.WriteLine("/*******************************************************************************");
            tw.WriteLine(TrimARow("** This file is genereted on: ", DateTime.Now.ToString(format), "**", 78));
            tw.WriteLine("**                                                                            **");
            tw.WriteLine("*******************************************************************************/");
            tw.WriteLine("#include \"Identification.h\"");
            tw.WriteLine("#if(MAGIC_NUMBER != " + MagicNumber.ToString() + ")");
            tw.WriteLine("    #error \"Inplausible genereted source files\"");
            tw.WriteLine("#endif /* (MAGIC_NUMBER != " + MagicNumber.ToString() + " */");
            tw.Write(_textStreamReader.ReadToEnd());
            for (int count = 0; count < TaskCounter; count++)
            {
                tw.WriteLine("/*****************************************************************************");
                tw.WriteLine(TrimARow("* Task Name: ", TaskList[count].GetTaskName(),"**", 76));
                tw.WriteLine("*****************************************************************************/");
                tw.WriteLine("void "+ TaskList[count].GetTaskName() + "_code(void)");
                tw.WriteLine("{");
                tw.WriteLine("    TerminateTsk();");
                tw.WriteLine("} /* End of " + TaskList[count].GetTaskName() + " */");
            }
      
            tw.WriteLine("");
            tw.WriteLine("/* EOF */");

            // close the stream
            tw.Close();
        }
        private void GenerateTMS_CMD_File(string FileName, int MagicNumber, string ResourceFolder, string DSTPath)
        {

            string ResourceName = "NewOSEKGen." + ResourceFolder + FileName;


            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream(ResourceName);
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream(ResourceName));
            }
            catch
            {
                MessageBox.Show("Error accessing resources!");
            }
            // create a writer and open the file
            string format = "d/M/yyyy HH:mm:ss";
            TextWriter tw = new StreamWriter(DSTPath + FileName);
            GenerateHeader(FileName, MicroSelection.SelectedItem.ToString(), tw);
            tw.WriteLine("/*******************************************************************************");
            tw.WriteLine(TrimARow("** This file is genereted on: ", DateTime.Now.ToString(format), "**", 78));
            tw.WriteLine("**                                                                            **");
            tw.WriteLine("*******************************************************************************/");
            
            tw.Write(_textStreamReader.ReadToEnd());


            // close the stream
            tw.Close();
        }
        private void GenerateIdentification_TMS(string FileName)
        {
            TextWriter tw = new StreamWriter(FileName + "Identification.h");
            tw.WriteLine("#define    MAGIC_NUMBER    "+MagicNumber.ToString());

            // close the stream
            tw.Close();
        }
        private void GenerateIdentification()
        {
            TextWriter tw = new StreamWriter(PathToGenerate.Text + "Identification.h");
            tw.WriteLine("#define    MAGIC_NUMBER    "+MagicNumber.ToString());
            if("MSP430FG4618" == MicroSelection.SelectedItem)
            {
                tw.WriteLine("#define    SELECTED_MICROCONTROLLER     _MSP430_xG46x_");
            }
            else if ("MSP430F5438" == MicroSelection.SelectedItem)
            {
                tw.WriteLine("#define    SELECTED_MICROCONTROLLER     _MSP430_x54x_");
            }
            else
            {
                MessageBox.Show("OS Generator", "Internal errror!");
            }
            // close the stream
            tw.Close();
        }
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            MagicNumber = RandomNumber(0x0, (int)50000000);
            int PathLengh = PathToGenerate.Text.Length;
            char LastChar = PathToGenerate.Text[PathLengh-1];
            if ('\\' != LastChar)
            {
                PathToGenerate.Text += "\\";
            }
            PathToGenerate.Text = this.PathToGenerate.Text;
            if (!Directory.Exists(PathToGenerate.Text))
            {
                MessageBox.Show("Configurated path for generation does not exist! Please select a correct path!");
                return;
               
            }
            if (
                ("MSP430FG4618" == MicroSelection.SelectedItem)||
                ("MSP430F5438" == MicroSelection.SelectedItem)
                )
            {
                GenerateIdentification();
                GenerateFile("Task.c", MagicNumber);
                GenerateFile("Alarm.c", MagicNumber);
                GenerateFile("Counter.c", MagicNumber);
                GenerateFile("Event.c", MagicNumber);
                GenerateFile("MCU_HAL.h", MagicNumber);
                GenerateFile("MCU_HAL.c", MagicNumber);
                GenerateFile("Schedule.c", MagicNumber);
                GenerateFile("main.c", MagicNumber);

                GenerateFile("Alarm.h", MagicNumber);

                GenerateFile("BasicTypes.h", MagicNumber);
                GenerateFile("common.h", MagicNumber);
                GenerateFile("Counter.h", MagicNumber);
                GenerateFile("HW_config.h", MagicNumber);
                GenerateFile("Event.h", MagicNumber);
                GenerateFile("interrupts.h", MagicNumber);
                GenerateFile("OS_Arch.h", MagicNumber);
                GenerateFile("Task.h", MagicNumber);
                GenerateOSConf();
                GenerateTables();
                GenerateUserTasks();
                GenerateMSP430ASM();
            }
            else if ("Delfino TMS320F28335" == MicroSelection.SelectedItem)
            {
                //First, Generate the HW dependant Files
                string PathToCheck = PathToGenerate.Text + "\\HW\\";
                bool folderExists = Directory.Exists(PathToCheck);
                if (!folderExists)
                    Directory.CreateDirectory(PathToCheck);
                GenerateIdentification_TMS(PathToCheck);
                GenerateTMSFile("DefaultISR.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_Adc.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_CpuTimers.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_DevEmu.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_Device.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_DMA.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_ECan.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_ECap.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_EPwm.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_EQep.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_Gpio.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_I2c.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_Mcbsp.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_PieCtrl.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_PieVect.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_Sci.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_Spi.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_SysCtrl.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_Xintf.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("DSP2833x_XIntrupt.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("HW_Config.h", MagicNumber, "Files.", PathToCheck);
                GenerateTMSFile("InitHW.h", MagicNumber, "Files.", PathToCheck);

                //Second, Generate the OS Include Files
                PathToCheck = PathToGenerate.Text + "\\Include\\";
                folderExists = Directory.Exists(PathToCheck);
                if (!folderExists)
                    Directory.CreateDirectory(PathToCheck);
                GenerateTMSFile("Alarm.h", MagicNumber, "Includes.", PathToCheck);
                GenerateTMSFile("common.h", MagicNumber, "Includes.", PathToCheck);
                GenerateTMSFile("Compiler.h", MagicNumber, "Includes.", PathToCheck);
                GenerateTMSFile("Counter.h", MagicNumber, "Includes.", PathToCheck);
                GenerateTMSFile("Macros.h", MagicNumber, "Includes.", PathToCheck);
                Generate_TMS_OSConf(PathToCheck);
                Generate_OS_gen(PathToCheck);
                GenerateTMSFile("OS_Types.h", MagicNumber, "Includes.", PathToCheck);
                GenerateTMSFile("Platform_Types.h", MagicNumber, "Includes.", PathToCheck);
                GenerateTMSFile("Std_types.h", MagicNumber, "Includes.", PathToCheck);
                GenerateTMSFile("Task.h", MagicNumber, "Includes.", PathToCheck);
                //Third, Generate remaining OS root folder files
                PathToCheck = PathToGenerate.Text;
                GenerateTMSFile("DSP2833x_Device.h", MagicNumber, "Root.", PathToCheck);

                GenerateTMSFile("Alarm.c", MagicNumber, "Root.", PathToCheck);
                GenerateTMSFile("Counter.c", MagicNumber, "Root.", PathToCheck);
                GenerateTMSFile("DefaultInt.c", MagicNumber, "Root.", PathToCheck);
                GenerateTMSFile("DSP2833x_GlobalVariableDefs.c", MagicNumber, "Root.", PathToCheck);
                GenerateTMSFile("InitHW.c", MagicNumber, "Root.", PathToCheck);
                GenerateTMSFile("Main.c", MagicNumber, "Root.", PathToCheck);
                GenerateTMSFile("Schedule.c", MagicNumber, "Root.", PathToCheck);
                GenerateTMSFile("Task.c", MagicNumber, "Root.", PathToCheck);
                GenerateTMS_ASM_File("MyISR.asm", MagicNumber, "Root.", PathToCheck);
                GenerateTMS_UserTasks("UserTasks.c", MagicNumber, "Root.", PathToCheck);
                GenerateTMS_CMD_File("28335_RAM_lnk.cmd", MagicNumber, "Root.", PathToCheck);
                GenerateTMS_CMD_File("DSP2833x_Headers_nonBIOS.cmd", MagicNumber, "Root.", PathToCheck);
            }
            else
            {
                MessageBox.Show("Not defined type of micro!");            
            }
            MessageBox.Show( "Congratulations! Successfylly generated files are available at " + PathToGenerate.Text,"Kristian's OS Generator");
            
           

        }
        private string TrimARow(string p1, string p2,  string p3, int limit)
        {
            string s = p1;
           
            s = s + p2;
            s = s.PadRight(limit, ' ');
            s = s + p3;
            return s;


        }
        private void GenerateHeader(string FileName, string TargetHW, TextWriter p)
        {
            
            p.WriteLine("/*******************************************************************************");
            p.WriteLine("**                                                                            **");
            p.WriteLine(TrimARow("**  SRC-MODULE: ",FileName,"**",78));            
            p.WriteLine("**                                                                            **");
            p.WriteLine("**  Copyright (C) none (open standard)                                        **");
            p.WriteLine("**                                                                            **");
            p.WriteLine(TrimARow("**  TARGET    : ",TargetHW,"**",78));                                               
            p.WriteLine("**                                                                            **");
            p.WriteLine("**  COMPILER  : CCS                                                           **");
            p.WriteLine("**                                                                            **");
            p.WriteLine("**  PROJECT   : Open Source OSEK                                              **");
            p.WriteLine("**                                                                            **");
            p.WriteLine("**  AUTHOR    : Kristian Dilov                                                **");
            p.WriteLine("**                                                                            **");
            p.WriteLine("**  PURPOSE   : Scientific Research                                           **");
            p.WriteLine("**                                                                            **");
            p.WriteLine("**  REMARKS   : None                                                          **");
            p.WriteLine("**                                                                            **");
            p.WriteLine("**  PLATFORM DEPENDANT [yes/no]: yes                                          **");
            p.WriteLine("**                                                                            **");
            p.WriteLine("**  TO BE CHANGED BY USER [yes/no]: no                                        **");
            p.WriteLine("**                                                                            **");
            p.WriteLine("*******************************************************************************/");
            p.WriteLine("/*******************************************************************************");
            p.WriteLine("**                      Author Identity                                       **");
            p.WriteLine("********************************************************************************");
            p.WriteLine("**                                                                            **");
            p.WriteLine("** Initials     Name                       Organization                       **");
            p.WriteLine("** --------     -------------------------  -----------------------------------**");
            p.WriteLine("** KD           Kristian Dilov             TU-Sofia                           **");
            p.WriteLine("**                                                                            **");
            p.WriteLine("*******************************************************************************/");
        }
        private void GenerateHeader_asm(string FileName, string TargetHW, TextWriter p)
        {

            p.WriteLine(";/******************************************************************************");
            p.WriteLine(";**                                                                           **");
            p.WriteLine(TrimARow(";**  SRC-MODULE: ", FileName, "**", 77));
            p.WriteLine(";**                                                                           **");
            p.WriteLine(";**  Copyright (C) none (open standard)                                       **");
            p.WriteLine(";**                                                                           **");
            p.WriteLine(TrimARow(";**  TARGET    : ", TargetHW, "**", 77));
            p.WriteLine(";**                                                                           **");
            p.WriteLine(";**  COMPILER  : CCS                                                          **");
            p.WriteLine(";**                                                                           **");
            p.WriteLine(";**  PROJECT   : Open Source OSEK                                             **");
            p.WriteLine(";**                                                                           **");
            p.WriteLine(";**  AUTHOR    : Kristian Dilov                                               **");
            p.WriteLine(";**                                                                           **");
            p.WriteLine(";**  PURPOSE   : Scientific Research                                          **");
            p.WriteLine(";**                                                                           **");
            p.WriteLine(";**  REMARKS   : None                                                         **");
            p.WriteLine(";**                                                                           **");
            p.WriteLine(";**  PLATFORM DEPENDANT [yes/no]: yes                                         **");
            p.WriteLine(";**                                                                           **");
            p.WriteLine(";**  TO BE CHANGED BY USER [yes/no]: no                                       **");
            p.WriteLine(";**                                                                           **");
            p.WriteLine(";******************************************************************************/");
            p.WriteLine(";/******************************************************************************");
            p.WriteLine(";**                      Author Identity                                      **");
            p.WriteLine(";*******************************************************************************");
            p.WriteLine(";**                                                                           **");
            p.WriteLine(";** Initials     Name                       Organization                      **");
            p.WriteLine(";** --------     -------------------------  ----------------------------------**");
            p.WriteLine(";** KD           Kristian Dilov             TU-Sofia                          **");
            p.WriteLine(";**                                                                           **");
            p.WriteLine(";******************************************************************************/");
        }
        private void GenerateASMHeader(string FileName, string TargetHW, TextWriter p)
        {
            
            p.WriteLine(";*******************************************************************************");
            p.WriteLine(";*                                                                            **");
            p.WriteLine(TrimARow(";*  SRC-MODULE: ",FileName,"**",78));            
            p.WriteLine(";*                                                                            **");
            p.WriteLine(";*  Copyright (C) none (open standard)                                        **");
            p.WriteLine(";*                                                                            **");
            p.WriteLine(TrimARow(";*  TARGET    : ",TargetHW,"**",78));                                               
            p.WriteLine(";*                                                                            **");
            p.WriteLine(";*  COMPILER  : CCS                                                           **");
            p.WriteLine(";*                                                                            **");
            p.WriteLine(";*  PROJECT   : Open Source OSEK                                              **");
            p.WriteLine(";*                                                                            **");
            p.WriteLine(";*  AUTHOR    : Kristian Dilov                                                **");
            p.WriteLine(";*                                                                            **");
            p.WriteLine(";*  PURPOSE   : Scientific Research                                           **");
            p.WriteLine(";*                                                                            **");
            p.WriteLine(";*  REMARKS   : None                                                          **");
            p.WriteLine(";*                                                                            **");
            p.WriteLine(";*  PLATFORM DEPENDANT [yes/no]: yes                                          **");
            p.WriteLine(";*                                                                            **");
            p.WriteLine(";*  TO BE CHANGED BY USER [yes/no]: no                                        **");
            p.WriteLine(";*                                                                            **");
            p.WriteLine(";*******************************************************************************");
            p.WriteLine(";*******************************************************************************");
            p.WriteLine(";*                      Author Identity                                       **");
            p.WriteLine(";*******************************************************************************");
            p.WriteLine(";*                                                                            **");
            p.WriteLine(";* Initials     Name                       Organization                       **");
            p.WriteLine(";* --------     -------------------------  -----------------------------------**");
            p.WriteLine(";* KD           Kristian Dilov             TU-Sofia                           **");
            p.WriteLine(";*                                                                            **");
            p.WriteLine(";*******************************************************************************");
        }
        private void Enabled_ISR_Nesting_CheckedChanged(object sender, EventArgs e)
        {
            OS_FORM.SetINTERRUPT_NESTING(Enabled_ISR_Nesting.Checked.ToString());
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            AnalysisForm AnalysisForm = new AnalysisForm(TaskList, AlarmList);
            
            
                



            AnalysisForm.Show();
            

        }

        private void AutoStartTask_CheckedChanged(object sender, EventArgs e)
        {
            ManageTskValues(true);
        }

        private void ValidateIt_Click(object sender, EventArgs e)
        {
            return; //Patch By Kristian
            int i;
            string ObjectName;
            TextWriter tw = new StreamWriter(PathToGenerate.Text + "ValidationReport.txt");
            for (i = 0; i < CounterList.GetLength(1); i++)
            {
                if ("" == CounterList[i].GetCounterName())
                {
                    ObjectName = "Counter problem: Counter with index " + i.ToString() + " ";
                    tw.WriteLine(ObjectName + " has no name assigned!");
                }
                else
                {
                    ObjectName = "Counter problem: Counter "+CounterList[i].GetTimerName() + " ";
                }
                if(
                    ("USERCOUNTER" != CounterList[i].GetTimerName()) && 
                    ("TIMER_A" != CounterList[i].GetTimerName()) && 
                    ("TIMER_B" != CounterList[i].GetTimerName())
                    )
                {
                    
                        tw.WriteLine(ObjectName + "has no associated timer!");
                    
                }
                if (
                    ("" != CounterList[i].GetMinCycle())
                    )
                {

                    tw.WriteLine(ObjectName + "has no associated timer!");

                }
                else
                {
                    if (!IsInteger(CounterList[i].GetMinCycle()))
                    {
                        tw.WriteLine(ObjectName +  " has invalid definition for MIN CYCLE, which does not contain only integers! [0-9]");
                    }
                    else if (1 > Convert.ToInt32(IsInteger(CounterList[i].GetMinCycle())) || Convert.ToInt32(IsInteger(CounterList[i].GetMinCycle()))>65535)
                    {
                        tw.WriteLine(ObjectName + "MIN CYCLE is not in the valid range [1-65535] !");
                    }
                
                }
            }




            tw.Close();

        }
        private bool IsInteger(string p)
        {
            for (int i = 0; i < p.Length; i++ ) 
            {
                if ((p[i] < '0') || (p[i] > '9')) return false;
            }
            return true;
        }

        private void MicroSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            OS_FORM.SetMicroSelection(MicroSelection.Text);
        }

        private void CC_SelectedIndexChanged(object sender, EventArgs e)
        {
            OS_FORM.SetCC(CC.Text);
        }

        private void STACK_CHECK_ENABLED_CheckedChanged(object sender, EventArgs e)
        {
            OS_FORM.SetSTACK_CHECK(STACK_CHECK_ENABLED.Checked.ToString());
        }

        private void ERROR_CHECKING_EXTENDEDK_ENABLED_CheckedChanged(object sender, EventArgs e)
        {
            OS_FORM.SetERROR_CHECKING_EXTENDED(ERROR_CHECKING_EXTENDEDK_ENABLED.Checked.ToString());
        }

        private void STARTUP_HOOK_ENABLED_CheckedChanged(object sender, EventArgs e)
        {
            OS_FORM.SetSTARTUP_HOOK(STARTUP_HOOK_ENABLED.Checked.ToString());
        }

        private void SHUTDOWN_HOOK_ENABLED_CheckedChanged(object sender, EventArgs e)
        {
            OS_FORM.SetSHUTDOWN_HOOK(SHUTDOWN_HOOK_ENABLED.Checked.ToString());
        }

        private void PRETASK_HOOK_ENABLED_CheckedChanged(object sender, EventArgs e)
        {
            OS_FORM.SetPRETASK_HOOK(PRETASK_HOOK_ENABLED.Checked.ToString());
        }

        private void POSTTASK_HOOK_ENABLED_CheckedChanged(object sender, EventArgs e)
        {
            OS_FORM.SetPOSTTASK_HOOK(POSTTASK_HOOK_ENABLED.Checked.ToString());
        }

        private void PREISR_HOOK_ENABLED_CheckedChanged(object sender, EventArgs e)
        {
            OS_FORM.SetPREISR_HOOK(PREISR_HOOK_ENABLED.Checked.ToString());
        }

        private void POSTISR_HOOK_ENABLED_CheckedChanged(object sender, EventArgs e)
        {
            OS_FORM.SetPOSTISR_HOOK(POSTISR_HOOK_ENABLED.Checked.ToString());
        }

        private void PathButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.PathToGenerate.Text = folderBrowserDialog1.SelectedPath;
                PathToGenerate.Text = this.PathToGenerate.Text + "\\";
            }
        }

       
        










    }
}
