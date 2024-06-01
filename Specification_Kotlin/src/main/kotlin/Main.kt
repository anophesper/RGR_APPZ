// Specification
interface ISpecification<T> {
    fun isSatisfiedBy(candidate: T): Boolean
}

// ConcreteSpecification
class AgeSpecification(private val minAge: Int, private val maxAge: Int) : ISpecification<Person> {
    override fun isSatisfiedBy(candidate: Person): Boolean {
        return candidate.age in minAge..maxAge
    }
}

// Entity
data class Person(val name: String, val age: Int)

// Client code
fun main() {
    val spec = AgeSpecification(18, 30)

    val person1 = Person("John Doe", 25)
    val person2 = Person("Jane Doe", 35)

    println("Person ${person1.name} is satisfied by specification: ${spec.isSatisfiedBy(person1)}")
    println("Person ${person2.name} is satisfied by specification: ${spec.isSatisfiedBy(person2)}")
}
