## Challenge Project: Developing a Project with Aspect-Oriented Programming Paradigm

In this project, the proposal is to implement a solution involving the Aspect-Oriented Programming Paradigm. For this to be possible, it is advisable to work with a primary programming paradigm for the main project, such as the Object-Oriented Paradigm.

The proposal involves creating a cross-cutting function in the code applied in different calls, all for the same goal. As a base project example, we can use the following problem:

Default problem: In a banking system, the client can choose to make withdrawals from different accounts (checking, salary, savings, investment). However, a message must be generated informing if the balance is insufficient for the requested amount. This message should be generated through an error log involving all accounts, meaning all accounts must be checked before releasing the money, analyzing its availability, and, if not possible, generating an insufficient balance message.

The main program implemented in the Object-Oriented Paradigm should address the basic functions of the bank account, while the balance check, as it is present in all accounts, should be implemented in the Aspect-Oriented Paradigm.
