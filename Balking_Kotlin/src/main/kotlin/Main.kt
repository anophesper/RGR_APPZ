import java.util.concurrent.locks.ReentrantLock
import kotlin.concurrent.withLock

class Balking {
    private var isInitialized = false
    private val lock = ReentrantLock()

    fun initialize() {
        lock.withLock {
            if (isInitialized) {
                return // Balking
            }
            // Initialization code
            println("Initializing...")
            isInitialized = true
        }
    }
}

// Client code
fun main() {
    val balking = Balking()

    val thread1 = Thread { balking.initialize() }
    val thread2 = Thread { balking.initialize() }

    thread1.start()
    thread2.start()

    thread1.join()
    thread2.join()
}
