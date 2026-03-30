public class ExampleFactory : Factory
    <ExampleFactory, ExampleObjectToSpawnByFactory, ExampleFactoryParams>
{
    public override ExampleObjectToSpawnByFactory Create(ExampleFactoryParams param)
    {
        ExampleObjectToSpawnByFactory obj = Instantiate(param.Prefab, param.SpawnPos, param.SpawnRotation);
        obj.SpawnedBy = param.CreatedBy;
        return obj;
    }

    protected override ExampleFactory CreateInstance() => this;
}
