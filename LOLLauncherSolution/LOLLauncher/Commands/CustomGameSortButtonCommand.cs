using LOLLauncher.Common.Enums;
using LOLLauncher.Models;
using LOLLauncher.ViewModels.The_biggest_area.Play_content.Custom;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace LOLLauncher.Commands
{
	/// <summary>
	/// Команда сортировки списка лобби своих игр.
	/// </summary>
	public class CustomGameSortButtonCommand : ICommand
	{
		/// <summary>
		/// VM-компонент страницы со списком лобби своих игр.
		/// </summary>
		private readonly JoinCustomVM _joinCustomVM;

		/// <summary>
		/// Конструктор команды.
		/// </summary>
		/// <param name="joinCustomVM"> VM-компонент страницы со списком лобби своих игр. </param>
		public CustomGameSortButtonCommand(JoinCustomVM joinCustomVM)
        {
            _joinCustomVM = joinCustomVM;
        }

        public event EventHandler? CanExecuteChanged;

		public bool CanExecute(object? parameter)
		{
			return true;
		}

		public void Execute(object? parameter)
		{
			switch ((string)parameter!)
			{
				case "Name":
					switch (_joinCustomVM.SortedByName)
					{
						case SortDirection.None:
						case SortDirection.Descending:
							InsertionSort<string>(_joinCustomVM.Lobbies, nameof(Lobby.Name), 1);
							_joinCustomVM.SortedByName = SortDirection.Ascending;
							break;

						case SortDirection.Ascending:
							InsertionSort<string>(_joinCustomVM.Lobbies, nameof(Lobby.Name), -1);
							_joinCustomVM.SortedByName = SortDirection.Descending;
							break;
					}
					_joinCustomVM.SortedByOwner = SortDirection.None;
					_joinCustomVM.SortedByMap = SortDirection.None;
					break;

				case "Owner":
					switch (_joinCustomVM.SortedByOwner)
					{
						case SortDirection.None:
						case SortDirection.Descending:
							InsertionSort<string>(_joinCustomVM.Lobbies, nameof(Lobby.OwnerName), 1);
							_joinCustomVM.SortedByOwner = SortDirection.Ascending;
							break;

						case SortDirection.Ascending:
							InsertionSort<string>(_joinCustomVM.Lobbies, nameof(Lobby.OwnerName), -1);
							_joinCustomVM.SortedByOwner = SortDirection.Descending;
							break;
					}
					_joinCustomVM.SortedByName = SortDirection.None;
					_joinCustomVM.SortedByMap = SortDirection.None;
					break;

				case "Map":
					switch (_joinCustomVM.SortedByMap)
					{
						case SortDirection.None:
						case SortDirection.Descending:
							InsertionSort<int>(_joinCustomVM.Lobbies, nameof(Lobby.Map), 1);
							_joinCustomVM.SortedByMap = SortDirection.Ascending;
							break;

						case SortDirection.Ascending:
							InsertionSort<int>(_joinCustomVM.Lobbies, nameof(Lobby.Map), -1);
							_joinCustomVM.SortedByMap = SortDirection.Descending;
							break;
					}
					_joinCustomVM.SortedByName = SortDirection.None;
					_joinCustomVM.SortedByOwner = SortDirection.None;
					break;
			}
		}

		/// <summary>
		/// Сортировка вставками.
		/// </summary>
		/// <param name="collection"> Коллекция входная и выходная. </param>
		/// <param name="propertyName"> Свойство, по которому идёт сортировка. </param>
		/// <param name="direction"> Направление: -1 - по убыванию, 1 - по возрастанию. </param>
		private static void InsertionSort<T>(ObservableCollection<Lobby> collection, string propertyName, int direction) where T : IComparable<T>
		{
			for (int i = 1; i < collection.Count; i++)
			{
				for (int j = i; j > 0 && ((T)collection[j - 1].GetType().GetProperty(propertyName)!.GetValue(collection[j - 1])!)
								.CompareTo((T)collection[j].GetType().GetProperty(propertyName)!.GetValue(collection[j])!) == direction; j--)
				{
					collection.Move(j, j - 1);
				}
			}
		}
	}
}
