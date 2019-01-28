using PSK.Databases.LogisticsCRUD.Domain.Vehicle;

namespace PSK.Databases.LogisticsCRUD.Infrastructure.Factory
{
    public class VehicleSqlFactory : IVehicleSqlFactory
    {
        public string GetSqlForGet()
        {
            return "SELECT * FROM VEHICLE WHERE id = :id";
        }

        public string GetSqlForGetAll()
        {
            return "SELECT * FROM VEHICLE";
        }

        public string GetSqlForInsert()
        {
            return "INSERT INTO VEHICLE (ID, NUMBERPLATE, BRAND, PRODUCTION_YEAR, VIN, CREATION_DATE) VALUES (customer_id_sequence.nextval, :numberplate, :brand, :productionyear, :vin, sysdate)";
        }

        public string GetSqlForUpdate()
        {
            return "UPDATE VEHICLE SET NAME = :name, SURNAME = :surname, AGE = :age, where id = :id";
        }

        public string GetSqlForDelete()
        {
            return "DELETE FROM VEHICLE WHERE id = :id";
        }
    }
}