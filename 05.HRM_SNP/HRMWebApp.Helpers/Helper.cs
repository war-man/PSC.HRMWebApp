﻿using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HRMWebApp.Helpers
{
    public static class Helper
    {
        public static ContentResult ToJSON(this object obj)
        {
            JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
            {
                Error = (sender, args) =>
                { args.ErrorContext.Handled = true; }
            };
            return new ContentResult { Content = JsonConvert.SerializeObject(obj, jsonSerializerSettings), ContentType = "application/json", ContentEncoding = Encoding.UTF8 };
        }

        public static ContentResult JsonSucess()
        {
            return new ContentResult { Content = JsonConvert.SerializeObject(new { success = "success", status_code = 200 }), ContentType = "application/json", ContentEncoding = Encoding.UTF8 };
        }

        public static void AddRange<T>(this Stack<T> stack, IEnumerable<T> items)
        {
            IEnumerable<T> itemReverse = items.Reverse();
            foreach (var item in itemReverse)
            {
                stack.Push(item);
            }
        }

        public static T Map<T>(this object source)
        {
            Mapper.CreateMap(source.GetType(), typeof(T));
            T des = (T)Mapper.Map(source, source.GetType(), typeof(T));
            return des;
        }

        public static List<T> Map<T>(this IEnumerable<object> source)
        {
            Type sourceType = source.GetType().GetGenericArguments()[0];
            Mapper.CreateMap(sourceType, typeof(T));
            List<T> des = (List<T>)Mapper.Map(source, source.GetType(), typeof(List<T>));
            return des;
        }

        public static int RemoveAll<T>(this IList<T> list, Predicate<T> match)
        {
            int count = 0;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (match(list[i]))
                {
                    ++count;
                    list.RemoveAt(i);
                }
            }
            return count;
        }
    }
}
