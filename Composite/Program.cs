using Composite;
using Dir = Composite.Directory;
using File = Composite.File;

Component fileSystem = new Dir("Файловая система");

Component diskD = new Dir("Диск D");

Component secretFolder = new Dir("Секретная папка");
Component passwordsTxt = new File("passwords.txt");
secretFolder.Add(passwordsTxt);
diskD.Add(secretFolder);

Component photosFolder = new Dir("Папка с фотками");
Component iPhotoPng = new File("i.png");
Component youPhotoPng = new File("you.png");
photosFolder.Add(iPhotoPng);
photosFolder.Add(youPhotoPng);
diskD.Add(photosFolder);

fileSystem.Add(diskD);
fileSystem.Print();