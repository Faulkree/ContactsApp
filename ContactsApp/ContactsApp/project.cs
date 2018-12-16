using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// класс проекта
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список контактов
        /// </summary>
        public List<Contact> _contactslistone = new List<Contact>();
        // <summary>
    /// Функция, сортирующая список по алфавиту
    /// </summary>
    /// <param name="data">Список, который требуеться отсортировать</param>
    /// <returns></returns>
    public static Project Sort(Project data)
    {
        Project returneProject = new Project();
        returneProject._contactslistone.Add(data._contactslistone[0]);        
        for (int i=1;i<data._contactslistone.Count;i++)
        {
            if (data._contactslistone[i].SecondName[0] >= returneProject._contactslistone[i - 1].SecondName[0])
            {
                returneProject._contactslistone.Add(data._contactslistone[i]);
            }
            else
            {
                
                bool flag=false;
                int k = i - 1;
                while (data._contactslistone[i].SecondName[0] < returneProject._contactslistone[k].SecondName[0])
                {
                    if (k == 0)
                    {
                        returneProject._contactslistone.Insert(0, data._contactslistone[i]);
                        flag = true;
                        break;
                    }
                    k--;                    
                }
                if ((flag == false) &&(k==0))
                {
                    returneProject._contactslistone.Insert(1, data._contactslistone[i]);
                }
                if((flag == false) && (k != 0))
                {
                    returneProject._contactslistone.Insert(k+1, data._contactslistone[i]);
                }
            }

        }

        return returneProject;
    }

    /// <summary>
    /// Функция, сортирующая список совпадающих имён и фамилий по алфавиту
    /// </summary>
    /// <param name="data">Список, в котором ведёться поиск</param>
    /// <param name="find">Подстрока, которую нужно найти</param>
    /// <returns></returns>
    public static Project Sort(Project data,string find)
    {
        Project returnProject = new Project();
        for(int i=0;i<data._contactslistone.Count;i++)
        {
            if(data._contactslistone[i].SecondName.Contains(find) || data._contactslistone[i].Name.Contains(find))
            {
                returnProject._contactslistone.Add(data._contactslistone[i]);
            }

        }
        if(returnProject._contactslistone.Count==0)
        {
            returnProject = null;
            return returnProject;
        }
        Project.Sort(returnProject);
        return returnProject;
    }

    /// <summary>
    /// Поиск людей в списке с днём рождения в указанную дату
    /// </summary>
    /// <param name="data"></param>
    /// <param name="today"></param>
    /// <returns></returns>
    public static Project Birthday(Project data,DateTime today)
    {
        Project returnProject = new Project();
        for (int i = 0; i < data._contactslistone.Count; i++)
        {
            if((data._contactslistone[i].Birth.Day==today.Day) && (data._contactslistone[i].Birth.Month == today.Month))
            {
                returnProject._contactslistone.Add(data._contactslistone[i]);
            }
        }
        return returnProject;
    }    
    }
}
