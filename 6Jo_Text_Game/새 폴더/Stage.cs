
        public class Stage
        {
               
                private void StoreGoblin()
                {
                        Console.WriteLine("앗! 고블린을 만났다!");
                        warrior.SetChangedCallback(health =>
                        {
                                if (health <= 0)
                                {
                                        Console.WriteLine("플레이어 사망!");
                                        warrior.IsDead = false;
                                }
                        });
                        goblin.SetChangedCallback(health =>
                        {
                                if (health <= 0)
                                {
                                        Console.WriteLine("고블린 사망!");
                                        goblin.IsDead = false;
                                }
                        });

                        while (true)
                        {
                                if (!warrior.IsDead || !dragon.IsDead) { break; }

                                Console.WriteLine();
                                Console.WriteLine("용사가 고블린을 공격했다!");
                                goblin.TakeDamage(warrior.Attack);
                                Thread.Sleep(1000);
                                Console.WriteLine($"용사의 공격으로 고블린은 {warrior.Attack}만큼 피해를 입었다!");
                                Console.WriteLine($"고블린의 피는 {goblin.Health} 남았다!");
                                Thread.Sleep(1000);

                                if (!warrior.IsDead || !goblin.IsDead) { break; }

                                Console.WriteLine("고블린이 용사를 공격했다!");
                                warrior.TakeDamage(goblin.Attack);
                                Thread.Sleep(1000);
                                Console.WriteLine($"고블린의 공격으로 용사는은 {goblin.Attack}만큼 피해를 입었다!");
                                Console.WriteLine($"용사의 피는 {warrior.Health} 남았다!");
                                Thread.Sleep(2000);

                        }
                }

                private void StoreDragon()
                {
                        Console.WriteLine("앗! 드래곤을 만났다!");
                        warrior.SetChangedCallback(health =>
                        {
                                if (health <= 0)
                                {
                                        Console.WriteLine("플레이어 사망!");
                                        warrior.IsDead = false;
                                }
                        });
                        dragon.SetChangedCallback(health =>
                        {
                                if (health <= 0)
                                {
                                        Console.WriteLine("드래곤 사망!");
                                        dragon.IsDead = false;
                                }
                        });

                        while (true)
                        {
                                if (!warrior.IsDead || !dragon.IsDead) { break; }

                                Console.WriteLine();
                                Console.WriteLine("용사가 드래곤을 공격했다!");
                                dragon.TakeDamage(warrior.Attack);
                                Thread.Sleep(1000);
                                Console.WriteLine($"용사의 공격으로 드래곤은 {warrior.Attack}만큼 피해를 입었다!");
                                Console.WriteLine($"드래곤의 피는 {dragon.Health} 남았다!");
                                Thread.Sleep(1000);

                                if (!warrior.IsDead || !dragon.IsDead) { break; }

                                Console.WriteLine("드래곤이 용사를 공격했다!");
                                warrior.TakeDamage(dragon.Attack);
                                Thread.Sleep(1000);
                                Console.WriteLine($"드래곤의 공격으로 용사는은 {dragon.Attack}만큼 피해를 입었다!");
                                Console.WriteLine($"용사의 피는 {warrior.Health} 남았다!");
                                Thread.Sleep(2000);

                        }
                }
                public void Start()
                {

                        StoreGoblin();
                        if (!warrior.IsDead)
                        {
                                Console.WriteLine("아 죽었다!");
                                return;
                        }
            Console.WriteLine(  );
            Console.WriteLine(  "용사는 휴식 했다.");
            warrior.Health = 100;
            Console.WriteLine(  );
            StoreDragon();
                        if (!warrior.IsDead)
                        {
                                Console.WriteLine("퍄 망했다!");
                        }
                }
        }
