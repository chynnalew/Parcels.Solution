using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcels.Models;

namespace Parcels.Tests
{
  [TestClass]
  public class ParcelTests
  {
    [TestMethod]
    public void Parcel_CreateNewInstanceOfParcel_True()
    {
      Parcel newParcel = new Parcel(1, 1, 1);
      Assert.AreEqual(typeof(Parcel), newParcel.GetType());
    }
    [TestMethod]
    public void Parcel_ReadsParcelHeight_True()
    {
      Parcel testParcel = new Parcel(2, 3, 4);
      Assert.AreEqual(2, testParcel.Height);
    }
    [TestMethod]
    public void Parcel_ReadsParcelWidth_True()
    {
      Parcel testParcel = new Parcel(2, 3, 4);
      Assert.AreEqual(3, testParcel.Width);
    }
    [TestMethod]
    public void Parcel_ReadsParcelLength_True()
    {
      Parcel testParcel = new Parcel(2, 3, 4);
      Assert.AreEqual(4, testParcel.Length);
    }
    [TestMethod]
    public void Volume_ReturnsVolumeOfTestParcel_True()
    {
      Parcel testParcel = new Parcel(2, 3, 4);
      Assert.AreEqual(24, testParcel.Volume());
    }
    [TestMethod]
    public void CostToShip_ReturnsCostOfSmallPackage_True()
    {
      Parcel testParcel = new Parcel(1, 1, 1);
      Assert.AreEqual(0.25, testParcel.CostToShip());
    }
    [TestMethod]
    public void CostToShip_ReturnsCostOfMediumPackage_True()
    {
      Parcel testParcel = new Parcel(10, 1, 5);
      Assert.AreEqual(12.5, testParcel.CostToShip());
    }
    [TestMethod]
    public void CostToShip_ReturnsCostOfLargePackage_True()
    {
      Parcel testParcel = new Parcel(10, 9, 2);
      Assert.AreEqual(45, testParcel.CostToShip());
    }
    
  }
}