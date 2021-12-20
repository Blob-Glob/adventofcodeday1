                string path = @"C:\Users\Chris\source\repos\advent-day-3\advent-day-3\input.csv";
                var p = File.ReadAllLines(path);
                var inputOxygen = new List<string>(p);
                var inputCarbon = new List<string>(p);

                for (var x = 0; x < 12; x++)
                {
                    int zeroCountOxygen = 0;
                    int oneCountOxygen = 0;
                    for (var i = 0; i < inputOxygen.Count(); i++)
                    {
                        if (inputOxygen[i][x].ToString() == "0")
                        {
                            zeroCountOxygen++;
                        }
                        else
                        {
                            oneCountOxygen++;
                        }
                    }

                    if (inputOxygen.Count() > 1)
                    {
                        if (oneCountOxygen >= zeroCountOxygen)
                        {
                            inputOxygen.RemoveAll(value => value[x].ToString().Equals("0"));
                        }
                        else
                        {
                            inputOxygen.RemoveAll(value => value[x].ToString().Equals("1"));
                        }
                    }

                    int zeroCountCarbon = 0;
                    int oneCountCarbon = 0;
                    for (var i = 0; i < inputCarbon.Count(); i++)
                    {
                        if (inputCarbon[i][x].ToString() == "0")
                        {
                            zeroCountCarbon++;
                        }
                        else
                        {
                            oneCountCarbon++;
                        }
                    }

                    if (inputCarbon.Count() > 1)
                    {
                        if (oneCountCarbon < zeroCountCarbon)
                        {
                            inputCarbon.RemoveAll(value => value[x].ToString().Equals("0"));
                        }
                        else
                        {
                            inputCarbon.RemoveAll(value => value[x].ToString().Equals("1"));
                        }
                    }
                    
                }

                Console.WriteLine(inputOxygen.Count());
                Console.WriteLine(Convert.ToInt32(inputOxygen[0], 2));

                Console.WriteLine(inputCarbon.Count());
                Console.WriteLine(Convert.ToInt32(inputCarbon[0], 2));

                Console.WriteLine(Convert.ToInt32(inputOxygen[0], 2) * Convert.ToInt32(inputCarbon[0], 2));
