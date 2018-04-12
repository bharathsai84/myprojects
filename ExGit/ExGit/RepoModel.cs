using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExGit
{
    public class RepoModel : INotifyPropertyChanged
    {
        public int repoID { get; set; }
        public string name { get; set; }
        public string repourl { get; set; }
        public string WorkingDirectory { get; set; }
        public bool AutoTrack { get; set; }
        public bool EnableDesNot { get; set; }
        public string NotificationEmail { get; set; }
        public string CurrentBranch { get; set; }
        public bool IsUntrackedRepo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime? RecentCheck { get; set; }
        public bool IsActive { get; set; }               
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
       
    }
}
