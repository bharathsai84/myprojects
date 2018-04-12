using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ExGit
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string path = "Data Source=" + Windows.Storage.ApplicationData.Current.LocalFolder.Path + "\\GitMonitor.db";
        public int items;
        public ObservableCollection<RepoModel> inventoryList = new ObservableCollection<RepoModel>();
        public ObservableCollection<UntrackedModel> untrackedList = new ObservableCollection<UntrackedModel>();
        public MainPage()
        {
            this.InitializeComponent();
            inventoryList = GetProducts();
            untrackedList = Untracked();
        }
        public ObservableCollection<RepoModel> GetProducts()
        {
            try
            {
                var ImportedFiles = new ObservableCollection<RepoModel>();
                using (SqliteConnection con = new SqliteConnection(path))
                {
                    con.Open();
                    string stm = "SELECT * FROM tblRepo";
                    using (SqliteCommand cmd = new SqliteCommand(stm, con))
                    {
                        using (SqliteDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                var product = new RepoModel();
                                product.repoID = rdr.GetInt32(0);
                                product.name = rdr.IsDBNull(1) ? "null" : rdr.GetString(1);
                                product.repourl = rdr.IsDBNull(2) ? "null" : rdr.GetString(2);
                                product.WorkingDirectory = rdr.IsDBNull(3) ? null : rdr.GetString(3);
                                product.AutoTrack = rdr.GetBoolean(4);
                                product.EnableDesNot = rdr.GetBoolean(5);
                                product.NotificationEmail = rdr.IsDBNull(6) ? "null" : rdr.GetString(6);
                                product.CurrentBranch = rdr.IsDBNull(7) ? "null" : rdr.GetString(7);
                                product.IsUntrackedRepo = rdr.GetBoolean(8);
                                product.CreatedAt = rdr.GetDateTime(9);
                                product.ModifiedAt = rdr.GetDateTime(10);
                                product.RecentCheck = rdr.IsDBNull(11) ? (DateTime?)null : rdr.GetDateTime(11);
                                product.IsActive = rdr.GetBoolean(12);
                                ImportedFiles.Add(product);
                            }
                            return ImportedFiles;
                        }
                    }
                }
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
            }
            return null;
        }
        public ObservableCollection<UntrackedModel> Untracked()
        {
            try
            {
                var ImportedFiles = new ObservableCollection<UntrackedModel>();
                using (SqliteConnection con = new SqliteConnection(path))
                {
                    con.Open();
                    string stm = "SELECT * FROM tblRepo";
                    using (SqliteCommand cmd = new SqliteCommand(stm, con))
                    {
                        using (SqliteDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                var product = new UntrackedModel();
                                product.repoID = rdr.GetInt32(0);
                                product.name = rdr.IsDBNull(1) ? "null" : rdr.GetString(1);
                                product.CreatedAt = rdr.GetDateTime(9);
                                product.ModifiedAt = rdr.GetDateTime(10);
                                ImportedFiles.Add(product);
                            }
                            return ImportedFiles;
                        }
                    }
                }
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
            }
            return null;
        }

        private async void Setting_Click(object sender, RoutedEventArgs e)
        {
            CoreApplicationView newView = CoreApplication.CreateNewView();
            int newViewId = 0;
            await newView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Frame frame = new Frame();
                frame.Navigate(typeof(SettingsPage), null);
                Window.Current.Content = frame;
                // You have to activate the window in order to show it later.
                Window.Current.Activate();

                newViewId = ApplicationView.GetForCurrentView().Id;
            });
            bool viewShown = await ApplicationViewSwitcher.TryShowAsStandaloneAsync(newViewId);
        }

        private void ListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = e.AddedItems?.FirstOrDefault();
        }

        private void InventoryList_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private async void Edit_Click(object sender, RoutedEventArgs e)
        {
            CoreApplicationView newView = CoreApplication.CreateNewView();
            int newViewId = 0;
            await newView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Frame frame = new Frame();
                frame.Navigate(typeof(EditPage), null);
                Window.Current.Content = frame;
                // You have to activate the window in order to show it later.
                Window.Current.Activate();

                newViewId = ApplicationView.GetForCurrentView().Id;
            });
            bool viewShown = await ApplicationViewSwitcher.TryShowAsStandaloneAsync(newViewId);
        }

        private void Delete_click(object sender, RoutedEventArgs e)
        {
            using (SqliteConnection con = new SqliteConnection(path))
            {
                con.Open();
                int a = Convert.ToInt32(((ExGit.RepoModel)((Windows.UI.Xaml.FrameworkElement)sender).DataContext).repoID);
                string stm="delete from tblrepo where tblrepoID="+ a;
                using (SqliteCommand cmd = new SqliteCommand(stm, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            RepoModel repoModel= (ExGit.RepoModel)((Windows.UI.Xaml.FrameworkElement)sender).DataContext;
            inventoryList.Remove(repoModel);
        }
    }
}
