﻿using System;
using System.Collections.Generic;
using ShellLink.DataObjects;

namespace ShellLink.Validators
{
    public static class IDListValidator
    {
        public static void Check(this IDList obj, List<Exception> errors)
        {
            foreach (var itemId in obj.ItemIDList)
            {
                if (itemId == null)
                    errors.Add(new NullReferenceException("ItemId is null"));

                itemId?.Check(errors);
            }

            if (obj.TerminalID != 0)
                errors.Add(new ArgumentOutOfRangeException(nameof(obj.TerminalID), "TerminalID must be zero."));
        }

        public static bool Repair(this IDList obj)
        {
            obj.ItemIDList.RemoveAll(x => x == null);

            foreach (var itemId in obj.ItemIDList)
                itemId.Repair();

            obj.TerminalID = 0;

            return true;
        }
    }
}