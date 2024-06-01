// Product
interface IProduct {
    fun operation(): String
}

// ConcreteProduct
class ConcreteProductA : IProduct {
    override fun operation(): String {
        return "{Result of ConcreteProductA}"
    }
}

// ConcreteProduct
class ConcreteProductB : IProduct {
    override fun operation(): String {
        return "{Result of ConcreteProductB}"
    }
}

// Creator
abstract class Creator {
    abstract fun factoryMethod(): IProduct

    fun someOperation(): String {
        val product = factoryMethod()
        return "Creator: The same creator's code has just worked with ${product.operation()}"
    }
}

// ConcreteCreator
class ConcreteCreatorA : Creator() {
    override fun factoryMethod(): IProduct {
        return ConcreteProductA()
    }
}

class ConcreteCreatorB : Creator() {
    override fun factoryMethod(): IProduct {
        return ConcreteProductB()
    }
}

// Client code
fun main() {
    println("App: Launched with the ConcreteCreatorA.")
    clientCode(ConcreteCreatorA())

    println()

    println("App: Launched with the ConcreteCreatorB.")
    clientCode(ConcreteCreatorB())
}

fun clientCode(creator: Creator) {
    println("Client: I'm not aware of the creator's class, but it still works.\n${creator.someOperation()}")
}
