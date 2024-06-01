// Flyweight
interface Flyweight {
    fun operation(uniqueState: String)
}

// ConcreteFlyweight
class ConcreteFlyweight(private val sharedState: String) : Flyweight {
    override fun operation(uniqueState: String) {
        println("ConcreteFlyweight: Displaying shared ($sharedState) and unique ($uniqueState) state.")
    }
}

// FlyweightFactory
class FlyweightFactory(vararg states: String) {
    private val flyweights: MutableMap<String, Flyweight> = mutableMapOf()

    init {
        states.forEach { state ->
            flyweights[state] = ConcreteFlyweight(state)
        }
    }

    fun getFlyweight(sharedState: String): Flyweight {
        return flyweights.getOrPut(sharedState) {
            println("FlyweightFactory: Can't find a flyweight, creating new one.")
            ConcreteFlyweight(sharedState)
        }.also {
            println("FlyweightFactory: Reusing existing flyweight.")
        }
    }

    fun listFlyweights() {
        println("FlyweightFactory: I have ${flyweights.size} flyweights:")
        flyweights.keys.forEach { println(it) }
    }
}

// Client code
fun main() {
    val factory = FlyweightFactory("BMW_M5_black", "BMW_X6_red", "Mercedes_Benz_C300_black", "BMW_M5_red", "BMW_X1_white")

    factory.listFlyweights()

    addCarToPoliceDatabase(factory, "CL234IR", "James Doe", "BMW", "M5", "red")
    addCarToPoliceDatabase(factory, "CL234IR", "James Doe", "BMW", "X1", "white")

    factory.listFlyweights()
}

fun addCarToPoliceDatabase(factory: FlyweightFactory, plates: String, owner: String, brand: String, model: String, color: String) {
    println("\nClient: Adding a car to database.")
    val flyweight = factory.getFlyweight("${brand}_${model}_${color}")
    flyweight.operation("${plates}_${owner}")
}
