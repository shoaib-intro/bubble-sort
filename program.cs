
            bool swapped;
            int[] input=new int[] {54321};
            int temp;
            for (int i = 0; i < input.Length-1;i++ )
            {
                swapped = false;
                for (int j = 0; j < input.Length-i-1; j++)
                {
                    if (input[j + 1] < input[j])
                    {
                        temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = input[j];
                        swapped = true;
                        Console.WriteLine($"{input[j]}");
                    }

                    
                }
                if (swapped == false)
                    break;
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"Sorted Array is {input[i]}");
            }
