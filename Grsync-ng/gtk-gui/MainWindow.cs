
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.VBox vbox4;

	private global::Gtk.Label lbl_cmd;

	private global::Gtk.Notebook notebook1;

	private global::Gtk.VBox vbox1;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Label label4;

	private global::Gtk.Entry txb_source;

	private global::Gtk.Button btn_source_browse;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Label label5;

	private global::Gtk.Entry txb_destination;

	private global::Gtk.Button btn_dest_browse;

	private global::Gtk.Label label3;

	private global::Gtk.Table table3;

	private global::Gtk.Fixed arguments_left;

	private global::Gtk.Fixed arguments_right;

	private global::Gtk.Label label1;

	private global::Gtk.Label label2;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Button btn_run;

	private global::Gtk.Button btn_simulate;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Grsync-NG");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.DefaultWidth = 680;
		this.DefaultHeight = 400;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.lbl_cmd = new global::Gtk.Label();
		this.lbl_cmd.Name = "lbl_cmd";
		this.lbl_cmd.LabelProp = global::Mono.Unix.Catalog.GetString("Command will be generated here!");
		this.vbox4.Add(this.lbl_cmd);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.lbl_cmd]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.notebook1 = new global::Gtk.Notebook();
		this.notebook1.CanFocus = true;
		this.notebook1.Name = "notebook1";
		this.notebook1.CurrentPage = 0;
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Source:");
		this.hbox1.Add(this.label4);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label4]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.txb_source = new global::Gtk.Entry();
		this.txb_source.CanFocus = true;
		this.txb_source.Name = "txb_source";
		this.txb_source.IsEditable = true;
		this.txb_source.InvisibleChar = '•';
		this.hbox1.Add(this.txb_source);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.txb_source]));
		w4.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.btn_source_browse = new global::Gtk.Button();
		this.btn_source_browse.CanFocus = true;
		this.btn_source_browse.Name = "btn_source_browse";
		this.btn_source_browse.UseUnderline = true;
		this.btn_source_browse.Label = global::Mono.Unix.Catalog.GetString("Browse");
		this.hbox1.Add(this.btn_source_browse);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.btn_source_browse]));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		this.vbox1.Add(this.hbox1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Destination:");
		this.hbox2.Add(this.label5);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label5]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.txb_destination = new global::Gtk.Entry();
		this.txb_destination.CanFocus = true;
		this.txb_destination.Name = "txb_destination";
		this.txb_destination.IsEditable = true;
		this.txb_destination.InvisibleChar = '•';
		this.hbox2.Add(this.txb_destination);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.txb_destination]));
		w8.Position = 1;
		// Container child hbox2.Gtk.Box+BoxChild
		this.btn_dest_browse = new global::Gtk.Button();
		this.btn_dest_browse.CanFocus = true;
		this.btn_dest_browse.Name = "btn_dest_browse";
		this.btn_dest_browse.UseUnderline = true;
		this.btn_dest_browse.Label = global::Mono.Unix.Catalog.GetString("Browse");
		this.hbox2.Add(this.btn_dest_browse);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.btn_dest_browse]));
		w9.Position = 2;
		w9.Expand = false;
		w9.Fill = false;
		this.vbox1.Add(this.hbox2);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
		w10.Position = 1;
		w10.Expand = false;
		w10.Fill = false;
		this.notebook1.Add(this.vbox1);
		// Notebook tab
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Basic Information");
		this.notebook1.SetTabLabel(this.vbox1, this.label3);
		this.label3.ShowAll();
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.table3 = new global::Gtk.Table(((uint)(1)), ((uint)(2)), false);
		this.table3.Name = "table3";
		this.table3.RowSpacing = ((uint)(6));
		this.table3.ColumnSpacing = ((uint)(6));
		// Container child table3.Gtk.Table+TableChild
		this.arguments_left = new global::Gtk.Fixed();
		this.arguments_left.Name = "arguments_left";
		this.arguments_left.HasWindow = false;
		this.table3.Add(this.arguments_left);
		global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table3[this.arguments_left]));
		w12.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.arguments_right = new global::Gtk.Fixed();
		this.arguments_right.Name = "arguments_right";
		this.arguments_right.HasWindow = false;
		this.table3.Add(this.arguments_right);
		global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table3[this.arguments_right]));
		w13.LeftAttach = ((uint)(1));
		w13.RightAttach = ((uint)(2));
		w13.YOptions = ((global::Gtk.AttachOptions)(4));
		this.notebook1.Add(this.table3);
		global::Gtk.Notebook.NotebookChild w14 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.table3]));
		w14.Position = 1;
		// Notebook tab
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Switches");
		this.notebook1.SetTabLabel(this.table3, this.label1);
		this.label1.ShowAll();
		// Notebook tab
		global::Gtk.Label w15 = new global::Gtk.Label();
		w15.Visible = true;
		this.notebook1.Add(w15);
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Advanced");
		this.notebook1.SetTabLabel(w15, this.label2);
		this.label2.ShowAll();
		this.vbox4.Add(this.notebook1);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.notebook1]));
		w16.Position = 1;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.btn_run = new global::Gtk.Button();
		this.btn_run.CanFocus = true;
		this.btn_run.Name = "btn_run";
		this.btn_run.UseUnderline = true;
		this.btn_run.Label = global::Mono.Unix.Catalog.GetString("Run");
		this.hbox3.Add(this.btn_run);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.btn_run]));
		w17.Position = 0;
		w17.Expand = false;
		w17.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.btn_simulate = new global::Gtk.Button();
		this.btn_simulate.CanFocus = true;
		this.btn_simulate.Name = "btn_simulate";
		this.btn_simulate.UseUnderline = true;
		this.btn_simulate.Label = global::Mono.Unix.Catalog.GetString("Simulate");
		this.hbox3.Add(this.btn_simulate);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.btn_simulate]));
		w18.Position = 1;
		w18.Expand = false;
		w18.Fill = false;
		this.vbox4.Add(this.hbox3);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox3]));
		w19.Position = 2;
		w19.Expand = false;
		w19.Fill = false;
		this.Add(this.vbox4);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.btn_source_browse.Clicked += new global::System.EventHandler(this.OnBtnSourceBrowseClicked);
		this.btn_dest_browse.Clicked += new global::System.EventHandler(this.OnBtnDestBrowseClicked);
		this.btn_run.Clicked += new global::System.EventHandler(this.OnBtnRunClicked);
		this.btn_simulate.Clicked += new global::System.EventHandler(this.OnBtnSimulateClicked);
	}
}
