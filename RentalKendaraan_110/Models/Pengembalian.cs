﻿using System;
using System.Collections.Generic;

namespace RentalKendaraan_110.Models
{
    public partial class Pengembalian
    {
        public int IdPengambilan { get; set; }
        public DateTime? TglPengembalian { get; set; }
        public int? IdPeminjaman { get; set; }
        public int? IdKondisi { get; set; }
        public int? Denda { get; set; }

        public KondisiKendaraan IdKondisiNavigation { get; set; }
        public Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
