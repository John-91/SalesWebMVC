using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departaments.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; //DB has been Seeded
            }

            Departaments d1 = new Departaments(1, "Computers");
            Departaments d2 = new Departaments(2, "Electronics");
            Departaments d3 = new Departaments(3, "Fashion");
            Departaments d4 = new Departaments(4, "Books");

            Seller s1 = new Seller(1, "Jonathan Lima", "jonjon@hotmail.com", new DateTime(1991, 11, 26), 1500.0, d1);
            Seller s2 = new Seller(2, "Mozart Maia", "mozart@hotmail.com", new DateTime(1999, 6, 4), 1500.0, d2);
            Seller s3 = new Seller(3, "Daniel Amaro", "daniel@hotmail.com", new DateTime(1995, 11, 14), 1500.0, d2);
            Seller s4 = new Seller(4, "Thallita Pedreira", "thallita@hotmail.com", new DateTime(1997, 7, 10), 1500.0, d3);
            Seller s5 = new Seller(5, "Raul Luar", "raul@hotmail.com", new DateTime(1977, 7, 10), 1500.0, d4);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2019, 10, 28), 11000.0, SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2019, 10, 28), 9000.0, SaleStatus.Billed, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2019, 10, 28), 7000.0, SaleStatus.Billed, s3);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2019, 10, 28), 8000.0, SaleStatus.Billed, s4);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2019, 10, 28), 3000.0, SaleStatus.Billed, s5);

            _context.Departaments.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5);

            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5);

            _context.SaveChanges();
        }
    }
}
