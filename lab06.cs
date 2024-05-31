public class EmailSender
{
    // Статическое свойство для хранения единственного экземпляра EmailSender
	// Оно статическое, чтобы принадлежало классу, а не экземплярам, чтобы всегда остылать к одному и тому же
    protected static EmailSender EmailSenderSingleton { get; set; }

    // Приватный конструктор для предотвращения внешнего создания экземпляров
	// Он приватный, чтобы извне нельзя было наплодить лишние экземляры
    protected EmailSender() { }

    // Метод для получения единственного экземпляра EmailSender
	// Он статический, чтобы иметь возможность вызывать его, не создавая новый экземпляр класса
    public static EmailSender GetInstance()
    {
        // Если единственный экземпляр еще не создан
        if (EmailSenderSingleton == null)
        {
            // Создаём новый экземпляр и присвоить его статическому свойству
            EmailSenderSingleton = new EmailSender();
        }
        // Возвращаем единственный экземпляр
        return EmailSenderSingleton;
    }
}

public class System
{
    // Свойство для хранения экземпляра EmailSender
    public EmailSender EmailSenderExample { get; set; }

    // Метод для создания экземпляра EmailSender
	// Он не статический, так как не требует наличия экземляра класса системы
    public void CreateEmailSender()
    {
        // Устанавливаем EmailSenderExample в единственный экземпляр EmailSender
        EmailSenderExample = EmailSender.GetInstance();
    }

    // Метод для создания другого экземпляра EmailSender
	// Здесь то же самое
    public void CreateAnotherEmailSender()
    {
        // Устанавливаем EmailSenderExample в тот же самый единственный экземпляр EmailSender
        EmailSenderExample = EmailSender.GetInstance();
    }
	/*
	Если мы поочерёдно вызовем методы CreateEmailSender() и CreateAnotherEmailSender(),
	то первый создаст экземпляр класса EmailSender, а второй просто отошлёт нас к нему, 
	то есть вернёт нам уже имеющийся экземпляр, то есть положит его в переменную EmailSenderExample.
	*/
}
