using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace SqlSaturdayDemo2
{

	internal class ViewModelBase : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		internal void RaisePropertyChanged(string propertyName){
			if (PropertyChanged != null && !string.IsNullOrEmpty (propertyName))
				PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
		}
	
		#endregion



	}

	internal class MyPageViewModel : ViewModelBase
	{
		public MyPageViewModel ()
		{
			Persons = new ObservableCollection<Person> ();
			Persons.Add(new Person("Rui","Marinho"));
		}

		private string _firstName; 
		public string FirstName {
			get{ 
				return _firstName;
			}
			set{
				_firstName = value;
				RaisePropertyChanged ("FirstName");
			}
		}


		private string _lastName; 
		public string LastName {
			get{ 
				return _lastName;
			}
			set{
				_lastName = value;
				RaisePropertyChanged ("LastName");
			}
		}


		private ObservableCollection<Person> _persons; 
		public ObservableCollection<Person> Persons {
			get{ 
				return _persons;
			}
			set{
				_persons = value;
				RaisePropertyChanged ("Persons");
			}
		}

		public ICommand AddPersonCommand {
			get{ 
				return new Command(()=>{
					Persons.Add(new Person(FirstName,LastName));
					FirstName = LastName = string.Empty;
				});
			}
		}

	}
}

