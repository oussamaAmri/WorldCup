using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using static System.Collections.Specialized.BitVector32;

namespace WorldCupConsole.FinanceExercice;
﻿
public static class Financial
{
    // Retourne le point pour une action donnée à une date donnée
    // Si la date n'existe pas, on fait la moyenne entre la valeur à la date précédente et la valeur à la date suivante
    // Si l'action est inconnue ou bien qu'il n'y a pas des dates pour faire une approximation, on retourne null
    public static Point GetPointByDate(string actionName, DateTime dateTime)
    {
        var allActions = FakeData.GetActions();
Point point = null;
        foreach (var action in allActions)
        {
            if (action.Name == actionName)
            {
                point = CheckDate(dateTime, action);

                if (point == null)
                {
                    //Récuperer la valeur de la date précedente 
                    //Obtenir la date precedente 
                    //Récuperer la valeur de la date 

                    double valeurDatePrecedente = GetValuePrevious(dateTime, action);
                    //Récuperer la valeur de la date suivante
                    double valeurDateSuivante = GetValueNext(dateTime, action);
                    if (valeurDatePrecedente != -1)
                    {
                        //calculer la moyenne de ces deux valeurs
                        double moyenne = (valeurDatePrecedente + valeurDateSuivante) / 2;
                        point = new Point();
                        point.Value = moyenne;
                        point.Date = dateTime;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        return point;
    }

    private static Point CheckDate(DateTime dateTime, Action action) // paramèttre d'entrer
    {
        Point point = null; // paramèttre de sortie 
        foreach (var p in action.Points)
        {
            if (p.Date == dateTime)
            {
                point = p;
            }
        }
        return point;
    }

    private static double GetValuePrevious(DateTime dateTime, Action action)
    {
        int posPrecedente = -1;
        double valeurDatePrecedente;
        for (int i = 0; i < action.Points.Count; i++)
        {
            if (action.Points[i].Date > dateTime)
            {
                posPrecedente = i - 1;
                break;
            }
        }
        if (posPrecedente == -1)
        {
            return -1;
        }
        else
        {
            valeurDatePrecedente = action.Points[posPrecedente].Value;
        }
        return valeurDatePrecedente;
    }

    private static double GetValueNext(DateTime dateTime, Action action)
    {
        int posSuivante = -1;
        double valeurDateSuivante;
        for (int j = 0; j < action.Points.Count; j++)
        {
            if (action.Points[j].Date > dateTime)
            {
                posSuivante = j;
                break;
            }
        }
        if (posSuivante == -1)
        {
            return -1;
        }
        else
        {
            valeurDateSuivante = action.Points[posSuivante].Value;
        }
        return valeurDateSuivante;
    }
    // Retourne une liste de points entre 2 dates pour une action donnée
    // S'il manque une date, on fait la moyenne entre la valeur à la date précédente et la valeur à la date suivante
    // Dans le cas où il manque plusieurs dates d'affilées, on ne calcule qu'une seule fois la valeur moyenne et on renseigne tout l'interval
    // Si on arrive pas à calculer une approximation, on met la valeur du point à 0
    public static List<Point> GetPoints(string actionName, DateTime startDate, DateTime endDate)
    {
        Point point = null;
        List<Point> Point = new List<Point>();
        var allActions = FakeData.GetActions();
        foreach (var action in allActions)
        {
            if (action.Name == actionName)
            {
                DateTime dateTime = startDate;
                while(dateTime<=endDate)
                {
                    point = GetPointByDate(actionName,dateTime);
                    if (point != null)
                    {
                        Point.Add(point);
                    }
                    dateTime = dateTime.AddDays(1);
                }
/*                //Récuperer la pos du startDate 
                int posDebut = GetPosDebutPoints(startDate,action);
                //Récuperer la pos du endDate 
                int posFin = GetPosFinPoints(endDate,action);
                //Afficher les valeur entre les deux pos
                if (posDebut != -1 && posFin != -1)
                {

                    for (int i = posDebut; i <= posFin; i++)
                    {

                        point = CheckDate(dateTime, action);
                        Point.Add(action.Points[i]);
                    }
                }*/
            }
        }
        return Point;
    }

    private static int GetPosDebutPoints(DateTime startDate, Action action)
    {
        int posDebut = -1;
        for (int i = 0; i < action.Points.Count; i++)
        {
            if (action.Points[i].Date == startDate)
            {
                posDebut = i;
                break;
            }
        }
        if (posDebut == -1)
        {
            return -1;
        }
        return posDebut;
    }
    private static int GetPosFinPoints(DateTime endDate, Action action)
    {
        int posFin = -1;
        for (int j = 0; j < action.Points.Count; j++)
        {
            if (action.Points[j].Date == endDate)
            {
                posFin = j;
                break;
            }
        }
        if (posFin == -1)
        {
            return -1;
        }
        return posFin;
    }
}
