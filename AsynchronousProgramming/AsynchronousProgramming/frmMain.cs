using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;
namespace AsynchronousProgramming
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Delegate này chỉ gọi đến các phương thức có kiểu trả về là int 
        //và không có tham số
        private delegate int GetNumDelegate();
        private static int GetNum_1()
        {
            System.Threading.Thread.Sleep(3000);
            return 3;
        }
        private static int GetNum_2()
        {
            return 4;
        }
        private static void GetReturnValue(IAsyncResult res)
        {
            AsyncResult ar = (AsyncResult)res;
            int number = (int)ar.AsyncState;
            GetNumDelegate gnd = (GetNumDelegate)ar.AsyncDelegate;
            
            MessageBox.Show(gnd.EndInvoke(res).ToString(),"Called GetNum_1 method with "+number);
        }       
        private void btnTest_Click(object sender, EventArgs e)
        {
            int number=10000;
            //Gọi phương thức GetNum_1 theo cơ chế không đồng bộ
            GetNumDelegate gnd = new GetNumDelegate(GetNum_1);
            AsyncCallback acb = new AsyncCallback(GetReturnValue);
            IAsyncResult res = gnd.BeginInvoke(acb, number);

             //Gọi phương thức GetNum_2 
            MessageBox.Show(GetNum_2().ToString(), "Called GetNum_2 method !");                                 
        }
    }
}