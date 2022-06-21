        public void ChangeName(Student Name)
        {
            Console.WriteLine("Give a new name to the student");
            var newName = Console.ReadLine();
            if(newName != null){
                foreach(var n in newName)
                {
                    if(char.IsDigit(newName, n))
                    {
                        Console.WriteLine("Name cannot include numbers");
                    }
                }
                this.Name = newName;
            }
            else
            {
                Console.WriteLine("Name cannot be empty");
            }
        }
