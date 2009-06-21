using System;
using System.Collections.Generic;

namespace XsdDocumentation.Model
{
	public sealed class Configuration
	{
		public Configuration()
		{
			DocFileNames = new List<string>();
			SchemaFileNames = new List<string>();
			SchemaDependencyFileNames = new List<string>();
		}

		public string OutputFolderPath { get; set; }
		public bool DocumentRootSchemas { get; set; }
		public bool DocumentRootElements { get; set; }
		public bool DocumentConstraints { get; set; }
		public bool DocumentSchemas { get; set; }
		public bool DocumentSyntax { get; set; }
		public bool SchemaSetContainer { get; set; }
		public string SchemaSetTitle { get; set; }
		public bool NamespaceContainer { get; set; }
		public bool IncludeLinkUriInKeywordK { get; set; }
		public string AnnotationTransformFileName { get; set; }
		public List<string> SchemaFileNames { get; set; }
		public List<string> SchemaDependencyFileNames { get; set; }
		public List<string> DocFileNames { get; set; }
	}
}