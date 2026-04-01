using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoneGame
{
	public class Form1 : Form
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003Cooklkjlkj_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public Form1 _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
				int num = _003C_003E1__state;
				Form1 form = _003C_003E4__this;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					default:
						form.row1 = form.rnd.Next(0, 2);
						awaiter = Task.Delay(50).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0090;
					case 0:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0090;
					case 1:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_00ff;
					case 2:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_016e;
					case 3:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_01dc;
					case 4:
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter);
							num = (_003C_003E1__state = -1);
							goto IL_0642;
						}
						IL_0642:
						awaiter.GetResult();
						goto IL_0649;
						IL_0090:
						awaiter.GetResult();
						form.row2 = form.rnd.Next(0, 2);
						awaiter = Task.Delay(50).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00ff;
						IL_01dc:
						awaiter.GetResult();
						form.gamerum = true;
						form.line = 0;
						form.button3.Visible = false;
						form.button1.Enabled = true;
						form.button2.Enabled = true;
						goto IL_0649;
						IL_00ff:
						awaiter.GetResult();
						form.row3 = form.rnd.Next(0, 2);
						awaiter = Task.Delay(50).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 2);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_016e;
						IL_0649:
						if (!form.gamerum)
						{
							break;
						}
						if (form.leff)
						{
							form.leff = false;
							form.rig = false;
							if (form.line == 0)
							{
								if (form.row1 == 0)
								{
									form.pictureBox1.Visible = false;
									form.pictureBox17.Visible = true;
									form.line = 1;
								}
								else
								{
									form.stopgame();
									MessageBox.Show("you lost", "stone game");
									form.line = 0;
									form.deactivatebt();
								}
							}
							else if (form.line == 1)
							{
								if (form.row2 == 0)
								{
									form.pictureBox17.Visible = false;
									form.pictureBox18.Visible = false;
									form.pictureBox16.Visible = true;
									form.line = 2;
								}
								else
								{
									form.stopgame();
									MessageBox.Show("you lost", "stone game");
									form.line = 0;
									form.deactivatebt();
								}
							}
							else if (form.line == 2)
							{
								if (form.row3 == 0)
								{
									form.pictureBox16.Visible = false;
									form.pictureBox15.Visible = false;
									form.pictureBox7.Visible = true;
									form.line = 3;
								}
								else
								{
									form.stopgame();
									MessageBox.Show("you lost", "stone game");
									form.line = 0;
									form.deactivatebt();
								}
							}
							else if (form.line == 3)
							{
								if (form.row4 == 0)
								{
									form.pictureBox7.Visible = false;
									form.pictureBox6.Visible = false;
									form.pictureBox8.Visible = true;
									form.line = 4;
								}
								else
								{
									form.stopgame();
									MessageBox.Show("you lost", "stone game");
									form.line = 0;
									form.deactivatebt();
								}
							}
							else if (form.line == 4)
							{
								form.pictureBox8.Visible = false;
								form.stopgame();
								MessageBox.Show("you win!", "stone game");
								form.line = 0;
								form.deactivatebt();
							}
						}
						else if (form.rig)
						{
							form.leff = false;
							form.rig = false;
							if (form.line == 0)
							{
								if (form.row1 == 1)
								{
									form.pictureBox1.Visible = false;
									form.pictureBox18.Visible = true;
									form.line = 1;
								}
								else
								{
									form.stopgame();
									MessageBox.Show("you lost", "stone game");
									form.line = 0;
									form.deactivatebt();
								}
							}
							else if (form.line == 1)
							{
								if (form.row2 == 1)
								{
									form.pictureBox17.Visible = false;
									form.pictureBox18.Visible = false;
									form.pictureBox15.Visible = true;
									form.line = 2;
								}
								else
								{
									form.stopgame();
									MessageBox.Show("you lost", "stone game");
									form.line = 0;
									form.deactivatebt();
								}
							}
							else if (form.line == 2)
							{
								if (form.row3 == 1)
								{
									form.pictureBox16.Visible = false;
									form.pictureBox15.Visible = false;
									form.pictureBox6.Visible = true;
									form.line = 3;
								}
								else
								{
									form.stopgame();
									MessageBox.Show("you lost", "stone game");
									form.line = 0;
									form.deactivatebt();
								}
							}
							else if (form.line == 3)
							{
								if (form.row4 == 1)
								{
									form.pictureBox7.Visible = false;
									form.pictureBox6.Visible = false;
									form.pictureBox9.Visible = true;
									form.line = 4;
								}
								else
								{
									form.stopgame();
									MessageBox.Show("you lost", "stone game");
									form.line = 0;
									form.deactivatebt();
								}
							}
							else if (form.line == 4)
							{
								form.pictureBox9.Visible = false;
								form.stopgame();
								MessageBox.Show("you win!", "stone game");
								form.line = 0;
								form.deactivatebt();
							}
						}
						awaiter = Task.Delay(50).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 4);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0642;
						IL_016e:
						awaiter.GetResult();
						form.row4 = form.rnd.Next(0, 2);
						awaiter = form.show_path().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 3);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_01dc;
					}
				}
				catch (Exception exception)
				{
					_003C_003E1__state = -2;
					_003C_003Et__builder.SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				_003C_003Et__builder.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003Cshow_path_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Form1 _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
				int num = _003C_003E1__state;
				Form1 form = _003C_003E4__this;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					default:
						if (form.row1 == 0)
						{
							form.pictureBox17.Visible = true;
							awaiter = Task.Delay(1000).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_00a0;
						}
						form.pictureBox18.Visible = true;
						awaiter = Task.Delay(1000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0119;
					case 0:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_00a0;
					case 1:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0119;
					case 2:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0198;
					case 3:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0211;
					case 4:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0290;
					case 5:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0309;
					case 6:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0388;
					case 7:
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter);
							num = (_003C_003E1__state = -1);
							break;
						}
						IL_031c:
						if (form.row4 == 0)
						{
							form.pictureBox8.Visible = true;
							awaiter = Task.Delay(1000).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 6);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0388;
						}
						form.pictureBox9.Visible = true;
						awaiter = Task.Delay(1000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 7);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
						IL_0211:
						awaiter.GetResult();
						form.pictureBox15.Visible = false;
						goto IL_0224;
						IL_00a0:
						awaiter.GetResult();
						form.pictureBox17.Visible = false;
						goto IL_012c;
						IL_0309:
						awaiter.GetResult();
						form.pictureBox6.Visible = false;
						goto IL_031c;
						IL_0224:
						if (form.row3 == 0)
						{
							form.pictureBox7.Visible = true;
							awaiter = Task.Delay(1000).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 4);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0290;
						}
						form.pictureBox6.Visible = true;
						awaiter = Task.Delay(1000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 5);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0309;
						IL_0119:
						awaiter.GetResult();
						form.pictureBox18.Visible = false;
						goto IL_012c;
						IL_012c:
						if (form.row2 == 0)
						{
							form.pictureBox16.Visible = true;
							awaiter = Task.Delay(1000).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0198;
						}
						form.pictureBox15.Visible = true;
						awaiter = Task.Delay(1000).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 3);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0211;
						IL_0388:
						awaiter.GetResult();
						form.pictureBox8.Visible = false;
						goto end_IL_000e;
						IL_0290:
						awaiter.GetResult();
						form.pictureBox7.Visible = false;
						goto IL_031c;
						IL_0198:
						awaiter.GetResult();
						form.pictureBox16.Visible = false;
						goto IL_0224;
					}
					awaiter.GetResult();
					form.pictureBox9.Visible = false;
					end_IL_000e:;
				}
				catch (Exception exception)
				{
					_003C_003E1__state = -2;
					_003C_003Et__builder.SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				_003C_003Et__builder.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private IContainer components;

		private Random rnd = new Random();

		private int row1;

		private int row2;

		private int row3;

		private int row4;

		private int line;

		private int side;

		private bool leff;

		private bool rig;

		private bool gamerum;

		private PictureBox pictureBox1;

		private PictureBox pictureBox2;

		private PictureBox pictureBox3;

		private PictureBox pictureBox4;

		private PictureBox pictureBox5;

		private PictureBox pictureBox10;

		private Button button1;

		private Button button2;

		private PictureBox pictureBox15;

		private PictureBox pictureBox16;

		private PictureBox pictureBox17;

		private PictureBox pictureBox18;

		private Button button3;

		private PictureBox pictureBox6;

		private PictureBox pictureBox7;

		private PictureBox pictureBox8;

		private PictureBox pictureBox9;

		private PictureBox pictureBox11;

		private PictureBox pictureBox12;

		private PictureBox pictureBox13;

		private PictureBox pictureBox14;

		private HelpProvider helpProvider1;

		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			rig = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			leff = true;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void resetgame()
		{
			button3.Visible = true;
			pictureBox17.Visible = false;
			pictureBox18.Visible = false;
			pictureBox16.Visible = false;
			pictureBox15.Visible = false;
			pictureBox7.Visible = false;
			pictureBox6.Visible = false;
			pictureBox8.Visible = false;
			pictureBox9.Visible = false;
			pictureBox1.Visible = true;
		}

		private void stopgame()
		{
			gamerum = false;
			resetgame();
			button1.Enabled = false;
			button2.Enabled = false;
			rig = false;
			leff = false;
		}

		private void deactivatebt()
		{
			button1.Enabled = false;
			button2.Enabled = false;
			button3.Visible = true;
		}

		[AsyncStateMachine(typeof(_003Cshow_path_003Ed__18))]
		private Task show_path()
		{
			_003Cshow_path_003Ed__18 stateMachine = default(_003Cshow_path_003Ed__18);
			stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
			stateMachine._003C_003E4__this = this;
			stateMachine._003C_003E1__state = -1;
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
			return stateMachine._003C_003Et__builder.Task;
		}

		[AsyncStateMachine(typeof(_003Cooklkjlkj_003Ed__19))]
		private void ooklkjlkj(object sender, EventArgs e)
		{
			_003Cooklkjlkj_003Ed__19 stateMachine = default(_003Cooklkjlkj_003Ed__19);
			stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
			stateMachine._003C_003E4__this = this;
			stateMachine._003C_003E1__state = -1;
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoneGame.Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.pictureBox18 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox10).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox15).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox16).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox17).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox18).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox6).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox7).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox8).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox9).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox11).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox12).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox13).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox14).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new System.Drawing.Point(144, 479);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(44, 45);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new System.Drawing.Point(78, 367);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 65);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new System.Drawing.Point(184, 367);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(100, 65);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			this.pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
			this.pictureBox4.Location = new System.Drawing.Point(184, 296);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(100, 65);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 3;
			this.pictureBox4.TabStop = false;
			this.pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
			this.pictureBox5.Location = new System.Drawing.Point(78, 296);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(100, 65);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 4;
			this.pictureBox5.TabStop = false;
			this.pictureBox10.Image = (System.Drawing.Image)resources.GetObject("pictureBox10.Image");
			this.pictureBox10.Location = new System.Drawing.Point(119, 469);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(100, 65);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox10.TabIndex = 9;
			this.pictureBox10.TabStop = false;
			this.pictureBox15.BackColor = System.Drawing.Color.BlueViolet;
			this.pictureBox15.Image = (System.Drawing.Image)resources.GetObject("pictureBox15.Image");
			this.pictureBox15.Location = new System.Drawing.Point(211, 306);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(44, 45);
			this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox15.TabIndex = 17;
			this.pictureBox15.TabStop = false;
			this.pictureBox15.Visible = false;
			this.pictureBox16.BackColor = System.Drawing.Color.BlueViolet;
			this.pictureBox16.Image = (System.Drawing.Image)resources.GetObject("pictureBox16.Image");
			this.pictureBox16.Location = new System.Drawing.Point(105, 306);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(44, 45);
			this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox16.TabIndex = 18;
			this.pictureBox16.TabStop = false;
			this.pictureBox16.Visible = false;
			this.pictureBox17.BackColor = System.Drawing.Color.BlueViolet;
			this.pictureBox17.Image = (System.Drawing.Image)resources.GetObject("pictureBox17.Image");
			this.pictureBox17.Location = new System.Drawing.Point(105, 376);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(44, 45);
			this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox17.TabIndex = 19;
			this.pictureBox17.TabStop = false;
			this.pictureBox17.Visible = false;
			this.pictureBox18.BackColor = System.Drawing.Color.BlueViolet;
			this.pictureBox18.Image = (System.Drawing.Image)resources.GetObject("pictureBox18.Image");
			this.pictureBox18.Location = new System.Drawing.Point(211, 376);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(44, 45);
			this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox18.TabIndex = 20;
			this.pictureBox18.TabStop = false;
			this.pictureBox18.Visible = false;
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(3, 522);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "left";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(button1_Click);
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(265, 522);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "right";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(button2_Click);
			this.button3.Location = new System.Drawing.Point(144, 125);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 21;
			this.button3.Text = "start";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(ooklkjlkj);
			this.pictureBox6.BackColor = System.Drawing.Color.BlueViolet;
			this.pictureBox6.Image = (System.Drawing.Image)resources.GetObject("pictureBox6.Image");
			this.pictureBox6.Location = new System.Drawing.Point(211, 234);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(44, 45);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 29;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Visible = false;
			this.pictureBox7.BackColor = System.Drawing.Color.BlueViolet;
			this.pictureBox7.Image = (System.Drawing.Image)resources.GetObject("pictureBox7.Image");
			this.pictureBox7.Location = new System.Drawing.Point(105, 234);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(44, 45);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox7.TabIndex = 28;
			this.pictureBox7.TabStop = false;
			this.pictureBox7.Visible = false;
			this.pictureBox8.BackColor = System.Drawing.Color.BlueViolet;
			this.pictureBox8.Image = (System.Drawing.Image)resources.GetObject("pictureBox8.Image");
			this.pictureBox8.Location = new System.Drawing.Point(105, 164);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(44, 45);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox8.TabIndex = 27;
			this.pictureBox8.TabStop = false;
			this.pictureBox8.Visible = false;
			this.pictureBox9.BackColor = System.Drawing.Color.BlueViolet;
			this.pictureBox9.Image = (System.Drawing.Image)resources.GetObject("pictureBox9.Image");
			this.pictureBox9.Location = new System.Drawing.Point(211, 164);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(44, 45);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox9.TabIndex = 26;
			this.pictureBox9.TabStop = false;
			this.pictureBox9.Visible = false;
			this.pictureBox11.Image = (System.Drawing.Image)resources.GetObject("pictureBox11.Image");
			this.pictureBox11.Location = new System.Drawing.Point(78, 154);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(100, 65);
			this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox11.TabIndex = 25;
			this.pictureBox11.TabStop = false;
			this.pictureBox12.Image = (System.Drawing.Image)resources.GetObject("pictureBox12.Image");
			this.pictureBox12.Location = new System.Drawing.Point(184, 154);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(100, 65);
			this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox12.TabIndex = 24;
			this.pictureBox12.TabStop = false;
			this.pictureBox13.Image = (System.Drawing.Image)resources.GetObject("pictureBox13.Image");
			this.pictureBox13.Location = new System.Drawing.Point(184, 225);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(100, 65);
			this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox13.TabIndex = 23;
			this.pictureBox13.TabStop = false;
			this.pictureBox14.Image = (System.Drawing.Image)resources.GetObject("pictureBox14.Image");
			this.pictureBox14.Location = new System.Drawing.Point(78, 225);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(100, 65);
			this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox14.TabIndex = 22;
			this.pictureBox14.TabStop = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.BackColor = System.Drawing.Color.Blue;
			base.ClientSize = new System.Drawing.Size(346, 546);
			base.ControlBox = false;
			base.Controls.Add(this.pictureBox6);
			base.Controls.Add(this.pictureBox7);
			base.Controls.Add(this.pictureBox8);
			base.Controls.Add(this.pictureBox9);
			base.Controls.Add(this.pictureBox11);
			base.Controls.Add(this.pictureBox12);
			base.Controls.Add(this.pictureBox13);
			base.Controls.Add(this.pictureBox14);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.pictureBox18);
			base.Controls.Add(this.pictureBox17);
			base.Controls.Add(this.pictureBox16);
			base.Controls.Add(this.pictureBox15);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.pictureBox5);
			base.Controls.Add(this.pictureBox4);
			base.Controls.Add(this.pictureBox3);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.pictureBox10);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Form1";
			this.helpProvider1.SetShowHelp(this, false);
			this.Text = "Stone Game";
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox10).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox15).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox16).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox17).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox18).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox6).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox7).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox8).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox9).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox11).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox12).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox13).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox14).EndInit();
			base.ResumeLayout(false);
		}
	}
}
