﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAUDOTE.Command
{
    public interface ICommand
    {
        void Executar();
        void Desfazer();
    }
}
