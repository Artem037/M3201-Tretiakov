using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

// Тестовые сценарии из задания (раздел «Тестовые сценарии»).
// Значения по умолчанию: флот – один Venture, пояс «Пояс A» (4 а.е., Veldspar – 1.0),
// цикл добычи – 1 ч, станция – Imperial Refinery (налог 0%),
// прайс-лист – Tritanium 4, Pyerite 10, Mexallon 70, Isogen 150 ТГК.
public class ContractScenarioTests
{
    /*
    private readonly PriceList _defaultPriceList;

    public ContractScenarioTests()
    {
        // например:
        _priceList = new PriceList()
            .AddMineral(new Tritanium(), 4.0m)
            .AddMineral(new Pyerite(),  10.0m)
            .AddMineral(new Mexallon(), 70.0m)
            .AddMineral(new Isogen(),  150.0m);
    }
    */

    [Fact(DisplayName = "Сценарий 1. Успешное выполнение контракта")]
    public void Contract_WithSingleVenture_IsCompleted()
    {
        // Arrange: контракт на 6 ч
        // var contract = new Contract(...);

        // Act
        // var result = calculator.Calculate(contract, ...);

        // Assert: выполнен; 1 рейс, 4 цикла, время работы 6 ч;
        // добыто 400 м³, потерь нет; Tritanium – 8000;
        // выручка 32 000, содержание 6000, прибыль 26 000
        // Assert.Equal(result.Status, ContractStatusEnum.Completed);
        Assert.Fail("Сценарий не реализован");
    }

    [Fact(DisplayName = "Сценарий 2. Пустой флот")]
    public void Contract_WithEmptyFleet_CannotBeCreated()
    {
        // Arrange: флот без кораблей

        // Act

        // Assert: контракт не может быть создан
        Assert.Fail("Сценарий не реализован");
    }

    [Fact(DisplayName = "Сценарий 3. Групповой вылет разных кораблей")]
    public void Contract_WithMixedFleet_FliesAtSlowestShipSpeed()
    {
        // Arrange: флот – Venture (трюм 100 м³) и Epithal; контракт на 6 ч

        // Act

        // Assert: выполнен; полёт 2 ч, 1 рейс, 2 цикла, время работы 6 ч;
        // добыто 220 м³ (Venture – 200 м³, из них 100 м³ в трюме Epithal; Epithal – 20 м³);
        // Tritanium – 4400; выручка 17 600, содержание 9000, прибыль 8600
        Assert.Fail("Сценарий не реализован");
    }
}