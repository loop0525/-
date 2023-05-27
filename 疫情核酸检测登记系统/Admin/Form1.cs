namespace Admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //��ʼ���ر������ڹ���
            treeView1.Enabled= false;
            

        }
        public bool loginState = false;
        SearchForm searchForm;
        LoginForm loginForm;
        SignForm signForm;
        UserForm userForm;
        CkeckRegForm ckeckRegForm;
        public void FormSwitch(int i)
        {
            switch(i)
            {
                case 0:
                    //���ز�ѯ��Ϣ����
                    if(searchForm == null)
                    {
                        searchForm = new SearchForm(this);
                        searchForm.MdiParent = this;
                        searchForm.Parent = this.splitContainer1.Panel2;
                    }
                    if (loginForm != null)
                        loginForm.Hide();
                    if (signForm != null)
                        signForm.Hide();
                    if (userForm != null)
                        userForm.Hide();
                    if (ckeckRegForm != null)
                        ckeckRegForm.Hide();

                    searchForm.Show();
                    break;
                case 1:
                    //���ص�¼ע�ᴰ��
                    if(loginForm == null)
                    {
                        loginForm = new LoginForm(this);
                        loginForm.MdiParent = this;
                        loginForm.Parent = this.splitContainer1.Panel2;
                    }

                    if (signForm != null)
                        signForm.Hide();
                    if (userForm != null)
                        userForm.Hide();
                    if (ckeckRegForm != null)
                        ckeckRegForm.Hide();
                    if (searchForm != null)
                        searchForm.Hide();

                    loginForm.Show();
                    break;
                case 2:

                    //����ע�ᴰ��
                    if(signForm == null)
                    {
                        signForm = new SignForm(this);
                        signForm.MdiParent = this;
                        signForm.Parent = this.splitContainer1.Panel2;
                    }
                    if (loginForm != null)
                        loginForm.Hide();
                    if (userForm != null)
                        userForm.Hide();
                    if (ckeckRegForm != null)
                        ckeckRegForm.Hide();
                    if (searchForm != null)
                        searchForm.Hide();

                    signForm.Show();
                    break;
                case 3:
                    //���صǼ���Ϣ����
                    if(userForm== null)
                    {
                        userForm = new UserForm(this);
                        userForm.MdiParent = this;
                        userForm.Parent = this.splitContainer1.Panel2;
                    }

                    if (loginForm != null)
                        loginForm.Hide();
                    if (ckeckRegForm != null)
                        ckeckRegForm.Hide();
                    if (searchForm != null)
                        searchForm.Hide();
                    if (signForm != null)
                        signForm.Hide();

                    userForm.Show();
                    break;
                case 4:
                    //���غ���ǼǴ���
                    if(ckeckRegForm == null)
                    {
                        ckeckRegForm = new CkeckRegForm(this);
                        ckeckRegForm.MdiParent = this;
                        ckeckRegForm.Parent = this.splitContainer1.Panel2;
                    }
                    if (loginForm != null)
                        loginForm.Hide();
                    if (searchForm != null)
                        searchForm.Hide();
                    if (signForm != null)
                        signForm.Hide();
                    if (userForm != null)
                        userForm.Hide();

                    ckeckRegForm.Show();
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //FormSwitch(int i)
            //case 0:���ز�ѯ��Ϣ����             
            //case 1:���ص�¼����
            //case 2:����ע�ᴰ��   
            //case 3:���صǼ���Ϣ����
            //case 4:���غ���ǼǴ���
            FormSwitch(1);

        }
        //�˳�ϵͳ
        private void btn_UserInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //���β˵�ѡ���¼�
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach(TreeNode node in treeView1.Nodes)
            {
                //����Ĭ��ɫ
                node.BackColor= Color.White;   
                node.ForeColor= Color.Black;
            }
            //ѡ�к󱳾�ɫ��ǰ��ɫ����
            e.Node.BackColor = SystemColors.Highlight;
            e.Node.ForeColor = Color.White;

            if (e.Node.Text == "����Ǽ�")
            {
                FormSwitch(4);
            }
            else if(e.Node.Text == "��ѯ��Ϣ")
            {
                FormSwitch(0);
            }
            else if(e.Node.Text == "�Ǽ���Ϣ")
            {
                FormSwitch(3);
            }
        }

    }
}