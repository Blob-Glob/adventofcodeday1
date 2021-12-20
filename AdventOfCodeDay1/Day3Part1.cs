
                string path = @"C:\Users\Chris\source\repos\advent-day-3\advent-day-3\input.csv";
                var input = File.ReadAllLines(path);

                List<string> l1 = new List<string>();
                List<string> l2 = new List<string>();
                List<string> l3 = new List<string>();
                List<string> l4 = new List<string>();
                List<string> l5 = new List<string>();
                List<string> l6 = new List<string>();
                List<string> l7 = new List<string>();
                List<string> l8 = new List<string>();
                List<string> l9 = new List<string>();
                List<string> l10 = new List<string>();
                List<string> l11 = new List<string>();
                List<string> l12 = new List<string>();

                for (var i = 0; i < input.Count(); i++)
                {
                    l1.Add(input[i][0].ToString());
                    l2.Add(input[i][1].ToString());
                    l3.Add(input[i][2].ToString());
                    l4.Add(input[i][3].ToString());
                    l5.Add(input[i][4].ToString());
                    l6.Add(input[i][5].ToString());
                    l7.Add(input[i][6].ToString());
                    l8.Add(input[i][7].ToString());
                    l9.Add(input[i][8].ToString());
                    l10.Add(input[i][9].ToString());
                    l11.Add(input[i][10].ToString());
                    l12.Add(input[i][11].ToString());
                };


                var most1 = l1.GroupBy(i => i).OrderByDescending(grp => grp.Count())
      .Select(grp => grp.Key).First();
                var most2 = l2.GroupBy(i => i).OrderByDescending(grp => grp.Count())
      .Select(grp => grp.Key).First();
                var most3 = l3.GroupBy(i => i).OrderByDescending(grp => grp.Count())
      .Select(grp => grp.Key).First();
                var most4 = l4.GroupBy(i => i).OrderByDescending(grp => grp.Count())
      .Select(grp => grp.Key).First();
                var most5 = l5.GroupBy(i => i).OrderByDescending(grp => grp.Count())
      .Select(grp => grp.Key).First();
                var most6 = l6.GroupBy(i => i).OrderByDescending(grp => grp.Count())
       .Select(grp => grp.Key).First();
                var most7 = l7.GroupBy(i => i).OrderByDescending(grp => grp.Count())
      .Select(grp => grp.Key).First();
                var most8 = l8.GroupBy(i => i).OrderByDescending(grp => grp.Count())
      .Select(grp => grp.Key).First();
                var most9 = l9.GroupBy(i => i).OrderByDescending(grp => grp.Count())
      .Select(grp => grp.Key).First();
                var most10 = l10.GroupBy(i => i).OrderByDescending(grp => grp.Count())
      .Select(grp => grp.Key).First();
                var most11 = l11.GroupBy(i => i).OrderByDescending(grp => grp.Count())
        .Select(grp => grp.Key).First();
                var most12 = l12.GroupBy(i => i).OrderByDescending(grp => grp.Count())
        .Select(grp => grp.Key).First();

                string most = most1 + most2 + most3 + most4 + most5 + most6 + most7 + most8 + most9 + most10 + most11 + most12;

                string least = most.Replace('0', 'x').Replace('1', '0').Replace('x', '1');

                var output = Convert.ToInt32(most, 2) * Convert.ToInt32(least, 2);
