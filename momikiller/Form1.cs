using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace momikiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static RegistryKey Exploler;

        private void btn_Blockclick(object sender, EventArgs e)
        {
            //Exploler 폴더를 확인하고 DisallowRun 파일을 생성
            Exploler = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Exploler", true);
            if(Exploler == null)
            {
                Exploler = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Exploler");
            }
            Exploler.SetValue("DisallowRun", 1, RegistryValueKind.DWord);

            //DisallowRun 폴더를 생성 및 차단 목록
            RegistryKey DisallowRun = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Exploler\DisallowRun", true);
            if(DisallowRun == null)
            {
                DisallowRun = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Exploler\DisallowRun");
            }
            DisallowRun.SetValue("1", "kwdmeuie.exe", RegistryValueKind.String);
            DisallowRun.SetValue("2", "Ipyilsjoo.exe", RegistryValueKind.String);
            DisallowRun.SetValue("3", "ueulgzgha.exe", RegistryValueKind.String);

            //확인및 재부팅 요청
            lb_BlockCheck.Text = "차단이 완료되었습니다. 재부팅해주세요!";
            btn_Reboot.Enabled = true;
        }

        public static RegistryKey RestrictRun;
        private void btn_Allow_Click(object sender, EventArgs e)
        {
            Exploler.DeleteSubKeyTree(@"Software\Microsoft\Windows\CurrentVersion\Policies\Exploler"); //Exploler 폴더 삭제

            //Exploler 폴더 확인 및 생성 RestirctRun 파일 생성
            Exploler = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Exploler", true);
            if (Exploler == null)
            {
                Exploler = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Exploler");
            }
            Exploler.SetValue("RestrictRun", 1, RegistryValueKind.DWord);

            //RestrictRun 폴더 생성 및 허용 파일 지정
            RestrictRun = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Exploler\RestrictRun");
            if(RestrictRun == null)
            {
                RestrictRun = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Exploler\RestrictRun");
            }
            RestrictRun.SetValue("1", "kwdmeuie.exe", RegistryValueKind.String);
            RestrictRun.SetValue("2", "Ipyilsjoo.exe", RegistryValueKind.String);
            RestrictRun.SetValue("3", "ueulgzgha.exe", RegistryValueKind.String);

            //결과 출력 및 재부팅 요청
            lb_AllowCheck.Text = "허용 완료! 재부팅 해주세요.";
            btn_Reboot.Enabled = true;
        }

        private void btn_Reboot_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown.exe", "-r -t 2");
        }

        private void btn_Clear(object sender, EventArgs e)
        {
            btn_Reboot.Enabled = false;
            lb_BlockCheck.Text = "차단 결과";
            lb_AllowCheck.Text = "허용 결과";
            Exploler.DeleteSubKeyTree(@"Software\Microsoft\Windows\CurrentVersion\Policies\Exploler");
        }
    }
}
