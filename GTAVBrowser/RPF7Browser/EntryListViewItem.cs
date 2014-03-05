﻿/*
 
    Copyright (C) 2013, GTA-Network Team <contact at gta-network dot net>

    This software is provided 'as-is', without any express or implied
    warranty.  In no event will the authors be held liable for any damages
    arising from the use of this software.

    Permission is granted to anyone to use this software for any purpose,
    including commercial applications, and to alter it and redistribute it
    freely, subject to the following restrictions:

    1. The origin of this software must not be misrepresented; you must not
    claim that you wrote the original software. If you use this software
    in a product, an acknowledgment in the product documentation would be
    appreciated but is not required.
    2. Altered source versions must be plainly marked as such, and must not be
    misrepresented as being the original software.
    3. This notice may not be removed or altered from any source distribution.
 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GTANETWORKV.RPF7.Entries;

namespace GTANETWORKV
{
    public class EntryListViewItem : ListViewItem
    {
        public FileEntry Entry;
        public EntryListViewItem(FileEntry entry)
            : base(entry.Name)
        {
            this.Entry = entry;
            this.Entry.ViewItem = this;
            Update();
        }

        public void Update()
        {
            this.SubItems.Clear();
            base.Text = this.Entry.Name;
            this.SubItems.Add(String.Format("{0:n0}", Entry.Data.GetSize()));

            if (this.Entry is ResourceEntry)
            {
                this.SubItems.Add((this.Entry as ResourceEntry).Type.ToString());
            }
        }
    }
}