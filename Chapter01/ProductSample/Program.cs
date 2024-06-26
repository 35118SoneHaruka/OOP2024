﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    internal class Program {
        static void Main(string[] args) {

            Product karinto = new Product(123,"かりんとう",180);
            Product daihuku = new Product(124, "だいふく", 200);

            int price = karinto.Price;//税抜きの価格
            int taxIncluded = karinto.GetPriceIncludingTax();//税込みの価格

            int daihukuPrice = daihuku.Price;//税抜きの価格
            int daihukuTaxIncluded = daihuku.GetPriceIncludingTax();

            Console.WriteLine(karinto.Name + "の税込み金額" + taxIncluded + "円【税抜き" + price + "円】");
            Console.WriteLine(daihuku.Name + "の税込み金額" + taxIncluded + "円【税抜き" + price + "円】");


        }
    }
}
