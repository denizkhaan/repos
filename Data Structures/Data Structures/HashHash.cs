using System;
using System.Collections.Generic;

// Node class to represent a key-value pair in the hash table
public class KeyValuePair<TKey, TValue>
{
    public TKey Key { get; }
    public TValue Value { get; }

    public KeyValuePair(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }
}

// Hash table class with basic operations
public class HashTable<TKey, TValue>
{
    private const int Size = 10; // Size of the hash table
    private List<KeyValuePair<TKey, TValue>>[] buckets;

    public HashTable()
    {
        buckets = new List<KeyValuePair<TKey, TValue>>[Size];
    }

    // Hash function to determine the index in the hash table
    private int GetHashIndex(TKey key)
    {
        int hashCode = key.GetHashCode();
        return Math.Abs(hashCode % Size);
    }

    // Insert a key-value pair into the hash table
    public void Add(TKey key, TValue value)
    {
        int index = GetHashIndex(key);

        if (buckets[index] == null)
        {
            buckets[index] = new List<KeyValuePair<TKey, TValue>>();
        }

        // Check for duplicates and update the value if the key already exists
        foreach (var pair in buckets[index])
        {
            if (pair.Key.Equals(key))
            {
                pair.Value = value;
                return;
            }
        }

        // If the key doesn't exist, add a new key-value pair
        buckets[index].Add(new KeyValuePair<TKey, TValue>(key, value));
    }

    // Retrieve the value associated with a key from the hash table
    public TValue Get(TKey key)
    {
        int index = GetHashIndex(key);

        if (buckets[index] != null)
        {
            foreach (var pair in buckets[index])
            {
                if (pair.Key.Equals(key))
                {
                    return pair.Value;
                }
            }
        }

        // Key not found
        throw new KeyNotFoundException($"Key '{key}' not found in the hash table.");
    }
}

class Program
{
    static void Main()
    {
        // Create a hash table
        HashTable<string, int> hashTable = new HashTable<string, int>();

        // Add key-value pairs
        hashTable.Add("one", 1);
        hashTable.Add("two", 2);
        hashTable.Add("three", 3);

        // Retrieve values
        Console.WriteLine("Value for key 'one': " + hashTable.Get("one"));
        Console.WriteLine("Value for key 'two': " + hashTable.Get("two"));
        Console.WriteLine("Value for key 'three': " + hashTable.Get("three"));

        // Try to retrieve a non-existing key
        try
        {
            Console.WriteLine("Value for key 'four': " + hashTable.Get("four"));
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
