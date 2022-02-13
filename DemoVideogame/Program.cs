//https://www.youtube.com/watch?v=Ab9HxiPLryg

using DemoVideogame;

var Enemy = new BaseEnemy();
//var Enemy = new BossEnemy();

var computedDamage = Enemy.TakeDamage();

Console.WriteLine("Daño recibido - Base Enemy: " + computedDamage);

var EnemyWithHelmet = new HelmetDecorator(Enemy);

var computedDamageHelmet = EnemyWithHelmet.TakeDamage();

Console.WriteLine("Daño recibido - Base Enemy with Helmet: " + computedDamageHelmet);

//var EnemyWithHelmetAndArmour = new ArmourDecorator(EnemyWithHelmet);

//var computedDamageHelmetArmour = EnemyWithHelmetAndArmour.TakeDamage();

//Console.WriteLine("Daño recibido - Base Enemy with Helmet and Armour: " + computedDamageHelmetArmour);

var EnemyWithHelmetAndEscudo = new EscudoDecorator(EnemyWithHelmet,20);

var computedDamageHelmetEscudo= EnemyWithHelmetAndEscudo.TakeDamage();

Console.WriteLine("Daño recibido - Base Enemy with Helmet and Escudo: " + computedDamageHelmetEscudo);

computedDamageHelmetEscudo = EnemyWithHelmetAndEscudo.TakeDamage();

Console.WriteLine("Daño recibido - Base Enemy with Helmet and Escudo: " + computedDamageHelmetEscudo);

computedDamageHelmetEscudo = EnemyWithHelmetAndEscudo.TakeDamage();

Console.WriteLine("Daño recibido - Base Enemy with Helmet and Escudo: " + computedDamageHelmetEscudo);
Console.ReadKey();

//Agregar un Escudo decorator