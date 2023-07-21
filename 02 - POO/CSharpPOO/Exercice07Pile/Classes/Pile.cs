using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice07Pile.Classes
{
    // VERSION AVEC List<T>

    // si on veut aller plus loin, on pourra rendre notre liste compatible avec toutes les méthodes utilisant des enumerable en implémentant correctement l'interface IEnumerable
    //internal class Pile<T> //: IEnumerable 
    //{
    //    private List<T> _values = new List<T>();
    //    //private T[] _values2 = new T[1];

    //    public void Empiler(T element)
    //    {
    //        _values.Add(element);
    //    }

    //    public T Depiler()
    //    {
    //        if (_values.Count == 0)
    //            return default; // si la liste est vide, on retourne le type par défaut
    //        // on pourrait aussi lever une exception
    //        //    throw new Exception("La pile est vide!");

    //        T dernierElement = _values[_values.Count-1];
    //        _values.RemoveAt(_values.Count - 1);
    //        return dernierElement;
    //    }

    //    public T Lire(int i) // consulter la pile sans retirer un élément
    //    {
    //        if(i >= 0 && i < _values.Count)
    //        {
    //            return _values[i];
    //        }
    //        return default(T);
    //        // on pourrait aussi lever une exception
    //        //    throw new IndexOutOfRangeException("L'index i est en dehors des bornes de la pile");
    //    }

    //    public override string ToString()
    //    {
    //        return "Pile : " + string.Join(", ",_values);
    //    }

    //    //public IEnumerator GetEnumerator()
    //    //{
    //    //    return _values.GetEnumerator();
    //    //}
    //}


    // VERSION AVEC TABLEAU

    internal class Pile<T>
    {
        private T[] _elements = new T[0];

        public void Empiler(T element)
        {
            Array.Resize(ref _elements, _elements.Length + 1);
            _elements[_elements.Length - 1] = element;
        }

        public T Depiler()
        {
            if (_elements.Length == 0)
            {
                throw new InvalidOperationException("La pile est vide.");
                // ou return default(T); -> envoie la valeur par défaut selon le type de T, par exemple string = null, int = 0, etc.
            }
            else
            {
                T dernierElement = _elements[_elements.Length - 1];
                Array.Resize(ref _elements, _elements.Length - 1);
                return dernierElement;
            }
        }

        public T Lire(int i)
        {
            if (i >= 0 && i < _elements.Length)
                return _elements[i];
            else
                throw new IndexOutOfRangeException("L'index est en dehors des limites du tableau.");
        }

        public override string ToString()
        {
            return "Pile : " + string.Join(", ", _elements);
        }
    }
}
