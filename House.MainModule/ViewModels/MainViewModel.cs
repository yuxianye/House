using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using House.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace House.MainModule.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            //Login.UserControl1
        }

        #region HeaderModel

        private Header.ViewModels.HeaderViewModel headerViewModel = new Header.ViewModels.HeaderViewModel();
        public Header.ViewModels.HeaderViewModel HeaderViewModel
        {
            get { return headerViewModel; }
            set { Set(() => HeaderViewModel, ref headerViewModel, value); }
        }

        #endregion

        #region HeaderNewsModel

        private HeaderNews.ViewModels.HeaderNewsViewModel headerNewsViewModel = new HeaderNews.ViewModels.HeaderNewsViewModel();
        public HeaderNews.ViewModels.HeaderNewsViewModel HeaderNewsViewModel
        {
            get { return headerNewsViewModel; }
            set { Set(() => HeaderNewsViewModel, ref headerNewsViewModel, value); }
        }

        #endregion

        #region MainMenuViewModel

        private MainMenu.ViewModels.MainMenuViewModel mainMenuViewModel = new MainMenu.ViewModels.MainMenuViewModel();
        public MainMenu.ViewModels.MainMenuViewModel MainMenuViewModel
        {
            get { return mainMenuViewModel; }
            set { Set(() => MainMenuViewModel, ref mainMenuViewModel, value); }
        }

        #endregion

        #region FooterViewModel

        private Footer.ViewModels.FooterViewModel footerViewModel = new Footer.ViewModels.FooterViewModel();
        public Footer.ViewModels.FooterViewModel FooterViewModel
        {
            get { return footerViewModel; }
            set { Set(() => FooterViewModel, ref footerViewModel, value); }
        }

        #endregion

        #region

        /// <summary>
        /// 注册MVVMLight消息
        /// </summary>
        private void registerMessenger()
        {
            Messenger.Default.Register<ViewInfo>(this, MessengerToken.Navigate, Navigate);

            //Messenger.Default.Register<object>(this, Model.MessengerToken.ClosePopup, ClosePopup);

            //Messenger.Default.Register<MenuInfo>(this, Model.MessengerToken.SetMenuStatus, SetMenuStatus);
        }

        /// <summary>
        /// 取消注册MVVMlight消息
        /// </summary>
        private void unRegisterMessenger()
        {
            Messenger.Default.Unregister<ViewInfo>(this, MessengerToken.Navigate, Navigate);

            //Messenger.Default.Unregister<object>(this, Model.MessengerToken.ClosePopup, ClosePopup);

            //Messenger.Default.Unregister<MenuInfo>(this, Model.MessengerToken.SetMenuStatus, SetMenuStatus);
        }
        #endregion


        private void Navigate(ViewInfo viewInfo)
        {

        }
    }
}
