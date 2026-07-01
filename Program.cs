using DSATraining.Tests;
using DSATraining.Tests.Algorithms;
using DSATraining.Tests.InternalMath;

TestRunner.Run([
    ..BinarySearchTests.All(),
    ..DFSTests.All(),
    ..BFSTests.All(),
    ..SigmaTests.All()
]);
