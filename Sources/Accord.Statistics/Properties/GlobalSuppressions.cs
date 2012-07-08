// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project. 
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc. 
//
// To add a suppression to this file, right-click the message in the 
// Error List, point to "Suppress Message(s)", and click 
// "In Project Suppression File". 
// You do not need to add suppressions to this file manually. 

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue", Scope = "type", Target = "Accord.Statistics.Testing.HypothesisTestType")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Accord.Statistics.Testing.TTest.#PValueToStatistic(System.Double,Accord.Statistics.Distributions.Univariate.TDistribution,Accord.Statistics.Testing.HypothesisTestType)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Accord.Statistics.Testing.TTest.#StatisticToPValue(System.Double,Accord.Statistics.Distributions.Univariate.TDistribution,Accord.Statistics.Testing.HypothesisTestType)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Accord.Statistics.Testing.IPowerAnalysis.#GetEffectSize()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Accord.Statistics.Testing.IPowerAnalysis.#GetPower()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Accord.Statistics.Testing.IPowerAnalysis.#GetSampleSize()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Scope = "member", Target = "Accord.Statistics.Testing.PowerAnalysis`1.#.ctor(!0,System.Double,System.Double,System.Double)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue", Scope = "type", Target = "Accord.Statistics.Testing.DistributionTail")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue", Scope = "type", Target = "Accord.Statistics.Testing.KolmogorovSmirnovTestHypothesis")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue", Scope = "type", Target = "Accord.Statistics.Testing.TwoSampleKolmogorovSmirnovTestHypothesis")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Accord.Statistics.Testing.TTest.#PValueToStatistic(System.Double,Accord.Statistics.Distributions.Univariate.TDistribution,Accord.Statistics.Testing.DistributionTail)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Accord.Statistics.Testing.TTest.#StatisticToPValue(System.Double,Accord.Statistics.Distributions.Univariate.TDistribution,Accord.Statistics.Testing.DistributionTail)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type", Target = "Accord.Statistics.Kernels.Power")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Testing.Power.BaseTwoSamplePowerAnalysis.#Accord.Statistics.Testing.Power.IPowerAnalysis.Samples")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.WilcoxonDistribution.#ProbabilityDensityFunction(System.Double)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.WilcoxonDistribution.#LogProbabilityDensityFunction(System.Double)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.WilcoxonDistribution.#DistributionFunction(System.Double)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.MannWhitneyDistribution.#ProbabilityDensityFunction(System.Double)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.MannWhitneyDistribution.#LogProbabilityDensityFunction(System.Double)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.MannWhitneyDistribution.#DistributionFunction(System.Double)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue", Scope = "type", Target = "Accord.Statistics.Testing.Hypothesis")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue", Scope = "type", Target = "Accord.Statistics.Testing.OneSampleHypothesis")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue", Scope = "type", Target = "Accord.Statistics.Testing.TwoSampleHypothesis")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1023:IndexersShouldNotBeMultidimensional", Scope = "member", Target = "Accord.Statistics.Kernels.KernelFunctionCache.#Item[System.Int32,System.Int32]")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Accord.Statistics.Kernels.KernelFunctionCache.#GetDataCache()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Accord.Statistics.Kernels.KernelFunctionCache.#GetLeastRecentlyUsedList()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "KMeans", Scope = "type", Target = "Accord.Statistics.Models.Markov.Learning.SegmentalKMeansLearning")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "KMeans", Scope = "type", Target = "Accord.Statistics.Models.Markov.Learning.SegmentalKMeansLearning`1")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Accord.Statistics.Models.Fields.Functions.MarkovModelFactor")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Accord.Statistics.Models.Fields.Functions.MultivariateNormalMarkovModelFactor")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Accord.Statistics.Models.Fields.Functions.NormalMarkovModelFactor")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Accord.Statistics.Models.Fields.Functions.DiscreteMarkovModelFactor")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Mc", Scope = "type", Target = "Accord.Statistics.Testing.McNemarTest")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Function", Scope = "member", Target = "Accord.Statistics.Links.ILinkFunction.#Function(System.Double)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Accord.Statistics.Models.Markov.HiddenMarkovClassifier`1.#Load(System.IO.Stream)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Accord.Statistics.Models.Markov.HiddenMarkovClassifier`1.#Load(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Accord.Statistics.Models.Fields.HiddenConditionalRandomField`1.#Load(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Accord.Statistics.Models.Fields.ConditionalRandomField`1.#Load(System.IO.Stream)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Accord.Statistics.Models.Fields.ConditionalRandomField`1.#Load(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Accord.Statistics.Models.Fields.HiddenConditionalRandomField`1.#Load(System.IO.Stream)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Scope = "member", Target = "Accord.Statistics.Formats.ExcelReader.#GetWorksheet(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics.Distributions.Fitting")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics.Models.Markov.Topology")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics.Analysis.ContrastFunctions")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Function", Scope = "member", Target = "Accord.Statistics.Kernels.IKernel.#Function(System.Double[],System.Double[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics.Distributions")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics.Models.Markov")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics.Models.Regression")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics.Visualizations")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "Accord.Statistics.Analysis.PartialLeastSquaresAnalysis.#nipals(System.Double[,],System.Double[,],System.Int32,System.Double)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "Accord.Statistics.Analysis.PartialLeastSquaresAnalysis.#simpls(System.Double[,],System.Double[,],System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1809:AvoidExcessiveLocals", Scope = "member", Target = "Accord.Statistics.Analysis.PartialLeastSquaresAnalysis.#simpls(System.Double[,],System.Double[,],System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.Mixture`1.#Estimate(System.Double[],!0[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.Mixture`1.#Estimate(System.Double[],System.Double,System.Double[],!0[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.Mixture`1.#Estimate(System.Double[],System.Double[],!0[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1500:VariableNamesShouldNotMatchFieldNames", MessageId = "mean", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.NormalDistribution.#Fit(System.Double[],System.Double[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1500:VariableNamesShouldNotMatchFieldNames", MessageId = "variance", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.NormalDistribution.#Fit(System.Double[],System.Double[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "x+1", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.PoissonDistribution.#DistributionFunction(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Multivariate.Mixture`1.#Estimate(System.Double[][],!0[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Multivariate.Mixture`1.#Estimate(System.Double[][],System.Double,System.Double[],!0[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Multivariate.Mixture`1.#Estimate(System.Double[][],System.Double[],!0[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Multivariate.MultivariateContinuousDistribution.#Accord.Statistics.Distributions.IDistribution.ProbabilityFunction(System.Double[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Multivariate.MultivariateDiscreteDistribution.#Accord.Statistics.Distributions.IDistribution.ProbabilityFunction(System.Double[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.UnivariateDiscreteDistribution.#Accord.Statistics.Distributions.IDistribution.ProbabilityFunction(System.Double[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Accord.Statistics.Filters.FiltersSequence")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "Accord.Statistics.Models.Markov.HiddenMarkovModel.#Learn(System.Int32[][],System.Int32,System.Double)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "inputs+1", Scope = "member", Target = "Accord.Statistics.Models.Regression.LogisticRegression.#.ctor(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "inputs+1", Scope = "member", Target = "Accord.Statistics.Models.Regression.Linear.MultipleLinearRegression.#.ctor(System.Int32,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "degree+1", Scope = "member", Target = "Accord.Statistics.Models.Regression.Linear.PolynomialRegression.#.ctor(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.UnivariateContinuousDistribution.#Accord.Statistics.Distributions.IDistribution.ProbabilityFunction(System.Double[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Accord.Statistics.Filters.CodificationFilter+Options")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Accord.Statistics.Filters.DiscretizationFilter+Options")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Accord.Statistics.Filters.EqualizationFilter+Options")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Accord.Statistics.Filters.LinearScalingFilter+Options")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Accord.Statistics.Filters.NormalizationFilter+Options")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type", Target = "Accord.Statistics.Kernels.Linear")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "n", Scope = "member", Target = "Accord.Statistics.Tools.#Random(System.Int32,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "k", Scope = "member", Target = "Accord.Statistics.Tools.#Random(System.Int32,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "n", Scope = "member", Target = "Accord.Statistics.Tools.#Random(System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics.Models.Fields.Learning")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics.Moving")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics.Running")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Accord.Statistics.Distributions.Multivariate.NormalDistribution.#Estimate(System.Double[][],System.Double[],Accord.Statistics.Distributions.Fitting.NormalOptions)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.VonMisesDistribution.#Estimate(System.Double[],System.Double[],Accord.Statistics.Distributions.Fitting.VonMisesOptions)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Accord.Statistics.Moving.MovingNormalStatistics")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics.Analysis.ContrastFunctions")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics.Distributions")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics.Distributions.Fitting")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics.Models.Markov.Topology")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics.Models.Regression")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics.Visualizations")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics.Models.Fields")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Accord.Statistics.Models.Fields.Functions")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Analysis.PartialLeastSquaresAnalysis.#Accord.Statistics.IMultipleRegressionAnalysis.Outputs")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Analysis.PartialLeastSquaresAnalysis.#Accord.Statistics.IMultivariateAnalysis.Source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Analysis.PartialLeastSquaresAnalysis.#Accord.Statistics.Analysis.IMultipleRegressionAnalysis.Outputs")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Analysis.PartialLeastSquaresAnalysis.#Accord.Statistics.Analysis.IMultivariateAnalysis.Source")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Analysis.PartialLeastSquaresAnalysis.#Accord.Statistics.Analysis.IProjectionAnalysis.Transform(System.Double[,])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Analysis.PartialLeastSquaresAnalysis.#Accord.Statistics.Analysis.IProjectionAnalysis.Transform(System.Double[,],System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Accord.Statistics.Filters.Discretization+Options")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Accord.Statistics.Filters.Equalization+Options")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Accord.Statistics.Filters.LinearScaling+Options")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Accord.Statistics.Filters.Normalization+Options")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Accord.Statistics.Filters.Codification+Options")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.NormalDistribution.#Estimate(System.Double[],System.Double[],Accord.Statistics.Distributions.Fitting.NormalOptions)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Accord.Statistics.Models.Markov.HiddenMarkovModel`1.#CreateDiscrete(Accord.Statistics.Models.Markov.Topology.ITopology,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Accord.Statistics.Models.Markov.HiddenMarkovModel`1.#CreateDiscrete(System.Double[,],System.Double[,],System.Double[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Accord.Statistics.Models.Markov.HiddenMarkovModel`1.#CreateDiscrete(System.Int32,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Accord.Statistics.Testing.TwoWayAnova.#.ctor(System.Double[],System.Int32[],System.Int32[],Accord.Statistics.Testing.TwoWayAnovaModel)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Accord.Statistics.Testing.TwoWayAnova.#.ctor(System.Double[][][],Accord.Statistics.Testing.TwoWayAnovaModel)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Accord.Statistics.Tools.#Standardize(System.Double[,],System.Double[],System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Accord.Statistics.Tools.#Standardize(System.Double[][],System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Accord.Statistics.Tools.#Standardize(System.Double[][],System.Double[],System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Multivariate.MultivariateMixture`1.#Estimate(System.Double[][],!0[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Multivariate.MultivariateMixture`1.#Estimate(System.Double[][],System.Double,System.Double[],!0[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Multivariate.MultivariateMixture`1.#Estimate(System.Double[][],System.Double[],!0[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Accord.Statistics.Distributions.Multivariate.MultivariateNormalDistribution.#Estimate(System.Double[][],System.Double[],Accord.Statistics.Distributions.Fitting.NormalOptions)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.LognormalDistribution.#Estimate(System.Double[],System.Double[],Accord.Statistics.Distributions.Fitting.NormalOptions)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.LognormalDistribution.#Estimate(System.Double[],System.Double[],Accord.Statistics.Distributions.Fitting.NormalOptions)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue", Scope = "type", Target = "Accord.Statistics.Testing.TwoWayAnovaModel")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Accord.Statistics.Visualizations.Scatterplot.#Compute(System.Double[,],System.Int32[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Accord.Statistics.Visualizations.Scatterplot.#Compute(System.Double[],System.Double[],System.Int32[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Accord.Statistics.Visualizations.Scatterplot.#Compute(System.Double[][],System.Int32[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Accord.Statistics.Tools.#Center(System.Double[,],System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Accord.Statistics.Tools.#Center(System.Double[,],System.Double[],System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Accord.Statistics.Tools.#Center(System.Double[][],System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Accord.Statistics.Tools.#Center(System.Double[][],System.Double[],System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Accord.Statistics.Tools.#Standardize(System.Double[,],System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Accord.Statistics.Filters.PrincipalComponentProjection+Options")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Indices", Scope = "member", Target = "Accord.Statistics.Analysis.DiscriminantAnalysisClass.#Indices")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Multivariate.MultivariateContinuousDistribution.#Accord.Statistics.Distributions.IDistribution.LogProbabilityFunction(System.Double[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Multivariate.MultivariateDiscreteDistribution.#Accord.Statistics.Distributions.IDistribution.LogProbabilityFunction(System.Double[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.UnivariateContinuousDistribution.#Accord.Statistics.Distributions.IDistribution.LogProbabilityFunction(System.Double[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.UnivariateContinuousDistribution.#Accord.Statistics.Distributions.IUnivariateDistribution.LogProbabilityFunction(System.Double)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.UnivariateContinuousDistribution.#Accord.Statistics.Distributions.IUnivariateDistribution.ProbabilityFunction(System.Double)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.UnivariateDiscreteDistribution.#Accord.Statistics.Distributions.IDistribution.LogProbabilityFunction(System.Double[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.UnivariateDiscreteDistribution.#Accord.Statistics.Distributions.IUnivariateDistribution.LogProbabilityFunction(System.Double)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Accord.Statistics.Distributions.Univariate.UnivariateDiscreteDistribution.#Accord.Statistics.Distributions.IUnivariateDistribution.ProbabilityFunction(System.Double)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Accord.Statistics.Models.Fields.Functions.FactorPotential`1")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Indices", Scope = "member", Target = "Accord.Statistics.Visualizations.ScatterplotClassValueCollection.#Indices")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Scope = "member", Target = "Accord.Statistics.Formats.ExcelSpreadsheetReader.#GetWorksheet(System.String)")]
