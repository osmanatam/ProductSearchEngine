﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
// Code is generated on: 14 Ocak 2012 Cumartesi 02:54:11
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using ProductSearchEngine;
using ProductSearchEngine.FactoryClasses;
using ProductSearchEngine.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ProductSearchEngine.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: LastViewedProduct. </summary>
	public partial class LastViewedProductRelations
	{
		/// <summary>CTor</summary>
		public LastViewedProductRelations()
		{
		}

		/// <summary>Gets all relations of the LastViewedProductEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductEntityUsingProductId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between LastViewedProductEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// LastViewedProduct.ProductId - Product.Id
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product", false);
				relation.AddEntityFieldPair(ProductFields.Id, LastViewedProductFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LastViewedProductEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticLastViewedProductRelations
	{
		internal static readonly IEntityRelation ProductEntityUsingProductIdStatic = new LastViewedProductRelations().ProductEntityUsingProductId;

		/// <summary>CTor</summary>
		static StaticLastViewedProductRelations()
		{
		}
	}
}
