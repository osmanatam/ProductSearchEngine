﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.1
// Code is generated on: 28 Kasım 2011 Pazartesi 20:19:29
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using ProductSearchEngine;
using ProductSearchEngine.FactoryClasses;
using ProductSearchEngine.DaoClasses;
using ProductSearchEngine.RelationClasses;
using ProductSearchEngine.HelperClasses;
using ProductSearchEngine.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace ProductSearchEngine.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'Category'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class CategoryEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ProductSearchEngine.CollectionClasses.CategoryCollection	_categories;
		private bool	_alwaysFetchCategories, _alreadyFetchedCategories;
		private ProductSearchEngine.CollectionClasses.ProductCollection	_products;
		private bool	_alwaysFetchProducts, _alreadyFetchedProducts;
		private CategoryEntity _category;
		private bool	_alwaysFetchCategory, _alreadyFetchedCategory, _categoryReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Category</summary>
			public static readonly string Category = "Category";
			/// <summary>Member name Categories</summary>
			public static readonly string Categories = "Categories";
			/// <summary>Member name Products</summary>
			public static readonly string Products = "Products";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CategoryEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CategoryEntity() : base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="id">PK value for Category which data should be fetched into this Category object</param>
		public CategoryEntity(System.Int32 id)
		{
			InitClassFetch(id, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Category which data should be fetched into this Category object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CategoryEntity(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(id, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="id">PK value for Category which data should be fetched into this Category object</param>
		/// <param name="validator">The custom validator object for this CategoryEntity</param>
		public CategoryEntity(System.Int32 id, IValidator validator)
		{
			InitClassFetch(id, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CategoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_categories = (ProductSearchEngine.CollectionClasses.CategoryCollection)info.GetValue("_categories", typeof(ProductSearchEngine.CollectionClasses.CategoryCollection));
			_alwaysFetchCategories = info.GetBoolean("_alwaysFetchCategories");
			_alreadyFetchedCategories = info.GetBoolean("_alreadyFetchedCategories");

			_products = (ProductSearchEngine.CollectionClasses.ProductCollection)info.GetValue("_products", typeof(ProductSearchEngine.CollectionClasses.ProductCollection));
			_alwaysFetchProducts = info.GetBoolean("_alwaysFetchProducts");
			_alreadyFetchedProducts = info.GetBoolean("_alreadyFetchedProducts");
			_category = (CategoryEntity)info.GetValue("_category", typeof(CategoryEntity));
			if(_category!=null)
			{
				_category.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_categoryReturnsNewIfNotFound = info.GetBoolean("_categoryReturnsNewIfNotFound");
			_alwaysFetchCategory = info.GetBoolean("_alwaysFetchCategory");
			_alreadyFetchedCategory = info.GetBoolean("_alreadyFetchedCategory");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((CategoryFieldIndex)fieldIndex)
			{
				case CategoryFieldIndex.BaseCategoryId:
					DesetupSyncCategory(true, false);
					_alreadyFetchedCategory = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{
			_alreadyFetchedCategories = (_categories.Count > 0);
			_alreadyFetchedProducts = (_products.Count > 0);
			_alreadyFetchedCategory = (_category != null);
		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Category":
					toReturn.Add(Relations.CategoryEntityUsingIdBaseCategoryId);
					break;
				case "Categories":
					toReturn.Add(Relations.CategoryEntityUsingBaseCategoryId);
					break;
				case "Products":
					toReturn.Add(Relations.ProductEntityUsingCategoryId);
					break;
				default:
					break;				
			}
			return toReturn;
		}



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_categories", (!this.MarkedForDeletion?_categories:null));
			info.AddValue("_alwaysFetchCategories", _alwaysFetchCategories);
			info.AddValue("_alreadyFetchedCategories", _alreadyFetchedCategories);
			info.AddValue("_products", (!this.MarkedForDeletion?_products:null));
			info.AddValue("_alwaysFetchProducts", _alwaysFetchProducts);
			info.AddValue("_alreadyFetchedProducts", _alreadyFetchedProducts);
			info.AddValue("_category", (!this.MarkedForDeletion?_category:null));
			info.AddValue("_categoryReturnsNewIfNotFound", _categoryReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCategory", _alwaysFetchCategory);
			info.AddValue("_alreadyFetchedCategory", _alreadyFetchedCategory);

			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntityProperty(string propertyName, IEntity entity)
		{
			switch(propertyName)
			{
				case "Category":
					_alreadyFetchedCategory = true;
					this.Category = (CategoryEntity)entity;
					break;
				case "Categories":
					_alreadyFetchedCategories = true;
					if(entity!=null)
					{
						this.Categories.Add((CategoryEntity)entity);
					}
					break;
				case "Products":
					_alreadyFetchedProducts = true;
					if(entity!=null)
					{
						this.Products.Add((ProductEntity)entity);
					}
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Category":
					SetupSyncCategory(relatedEntity);
					break;
				case "Categories":
					_categories.Add((CategoryEntity)relatedEntity);
					break;
				case "Products":
					_products.Add((ProductEntity)relatedEntity);
					break;
				default:
					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "Category":
					DesetupSyncCategory(false, true);
					break;
				case "Categories":
					this.PerformRelatedEntityRemoval(_categories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Products":
					this.PerformRelatedEntityRemoval(_products, relatedEntity, signalRelatedEntityManyToOne);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			if(_category!=null)
			{
				toReturn.Add(_category);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_categories);
			toReturn.Add(_products);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Category which data should be fetched into this Category object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id)
		{
			return FetchUsingPK(id, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Category which data should be fetched into this Category object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Category which data should be fetched into this Category object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(id, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="id">PK value for Category which data should be fetched into this Category object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(id, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.Id, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CategoryRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'CategoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CategoryEntity'</returns>
		public ProductSearchEngine.CollectionClasses.CategoryCollection GetMultiCategories(bool forceFetch)
		{
			return GetMultiCategories(forceFetch, _categories.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CategoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CategoryEntity'</returns>
		public ProductSearchEngine.CollectionClasses.CategoryCollection GetMultiCategories(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiCategories(forceFetch, _categories.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'CategoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ProductSearchEngine.CollectionClasses.CategoryCollection GetMultiCategories(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiCategories(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CategoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductSearchEngine.CollectionClasses.CategoryCollection GetMultiCategories(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedCategories || forceFetch || _alwaysFetchCategories) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_categories);
				_categories.SuppressClearInGetMulti=!forceFetch;
				_categories.EntityFactoryToUse = entityFactoryToUse;
				_categories.GetMultiManyToOne(this, filter);
				_categories.SuppressClearInGetMulti=false;
				_alreadyFetchedCategories = true;
			}
			return _categories;
		}

		/// <summary> Sets the collection parameters for the collection for 'Categories'. These settings will be taken into account
		/// when the property Categories is requested or GetMultiCategories is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCategories(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_categories.SortClauses=sortClauses;
			_categories.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public ProductSearchEngine.CollectionClasses.ProductCollection GetMultiProducts(bool forceFetch)
		{
			return GetMultiProducts(forceFetch, _products.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public ProductSearchEngine.CollectionClasses.ProductCollection GetMultiProducts(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiProducts(forceFetch, _products.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public ProductSearchEngine.CollectionClasses.ProductCollection GetMultiProducts(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiProducts(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductSearchEngine.CollectionClasses.ProductCollection GetMultiProducts(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProducts || forceFetch || _alwaysFetchProducts) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_products);
				_products.SuppressClearInGetMulti=!forceFetch;
				_products.EntityFactoryToUse = entityFactoryToUse;
				_products.GetMultiManyToOne(null, this, null, filter);
				_products.SuppressClearInGetMulti=false;
				_alreadyFetchedProducts = true;
			}
			return _products;
		}

		/// <summary> Sets the collection parameters for the collection for 'Products'. These settings will be taken into account
		/// when the property Products is requested or GetMultiProducts is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProducts(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_products.SortClauses=sortClauses;
			_products.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'CategoryEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CategoryEntity' which is related to this entity.</returns>
		public CategoryEntity GetSingleCategory()
		{
			return GetSingleCategory(false);
		}

		/// <summary> Retrieves the related entity of type 'CategoryEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CategoryEntity' which is related to this entity.</returns>
		public virtual CategoryEntity GetSingleCategory(bool forceFetch)
		{
			if( ( !_alreadyFetchedCategory || forceFetch || _alwaysFetchCategory) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CategoryEntityUsingIdBaseCategoryId);
				CategoryEntity newEntity = new CategoryEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.BaseCategoryId.GetValueOrDefault());
				}
				if(fetchResult)
				{
					newEntity = (CategoryEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_categoryReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Category = newEntity;
				_alreadyFetchedCategory = fetchResult;
			}
			return _category;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Category", _category);
			toReturn.Add("Categories", _categories);
			toReturn.Add("Products", _products);
			return toReturn;
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		private void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			this.Fields = CreateFields();
			this.Validator = validatorToUse;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="id">PK value for Category which data should be fetched into this Category object</param>
		/// <param name="validator">The validator object for this CategoryEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 id, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(id, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_categories = new ProductSearchEngine.CollectionClasses.CategoryCollection();
			_categories.SetContainingEntityInfo(this, "Category");

			_products = new ProductSearchEngine.CollectionClasses.ProductCollection();
			_products.SetContainingEntityInfo(this, "Category");
			_categoryReturnsNewIfNotFound = false;
			PerformDependencyInjection();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BaseCategoryId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Id", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _category</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCategory(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _category, new PropertyChangedEventHandler( OnCategoryPropertyChanged ), "Category", ProductSearchEngine.RelationClasses.StaticCategoryRelations.CategoryEntityUsingIdBaseCategoryIdStatic, true, signalRelatedEntity, "Categories", resetFKFields, new int[] { (int)CategoryFieldIndex.BaseCategoryId } );		
			_category = null;
		}
		
		/// <summary> setups the sync logic for member _category</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCategory(IEntity relatedEntity)
		{
			if(_category!=relatedEntity)
			{		
				DesetupSyncCategory(true, true);
				_category = (CategoryEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _category, new PropertyChangedEventHandler( OnCategoryPropertyChanged ), "Category", ProductSearchEngine.RelationClasses.StaticCategoryRelations.CategoryEntityUsingIdBaseCategoryIdStatic, true, ref _alreadyFetchedCategory, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCategoryPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="id">PK value for Category which data should be fetched into this Category object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 id, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)CategoryFieldIndex.Id].ForcedCurrentValueWrite(id);
				CreateDAOInstance().FetchExisting(this, this.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (this.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}

		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateCategoryDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new CategoryEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CategoryRelations Relations
		{
			get	{ return new CategoryRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Category' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCategories
		{
			get { return new PrefetchPathElement(new ProductSearchEngine.CollectionClasses.CategoryCollection(), (IEntityRelation)GetRelationsForField("Categories")[0], (int)ProductSearchEngine.EntityType.CategoryEntity, (int)ProductSearchEngine.EntityType.CategoryEntity, 0, null, null, null, "Categories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProducts
		{
			get { return new PrefetchPathElement(new ProductSearchEngine.CollectionClasses.ProductCollection(), (IEntityRelation)GetRelationsForField("Products")[0], (int)ProductSearchEngine.EntityType.CategoryEntity, (int)ProductSearchEngine.EntityType.ProductEntity, 0, null, null, null, "Products", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Category'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCategory
		{
			get	{ return new PrefetchPathElement(new ProductSearchEngine.CollectionClasses.CategoryCollection(), (IEntityRelation)GetRelationsForField("Category")[0], (int)ProductSearchEngine.EntityType.CategoryEntity, (int)ProductSearchEngine.EntityType.CategoryEntity, 0, null, null, null, "Category", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override string LLBLGenProEntityName
		{
			get { return "CategoryEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The BaseCategoryId property of the Entity Category<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Category"."BaseCategoryId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> BaseCategoryId
		{
			get { return (Nullable<System.Int32>)GetValue((int)CategoryFieldIndex.BaseCategoryId, false); }
			set	{ SetValue((int)CategoryFieldIndex.BaseCategoryId, value, true); }
		}

		/// <summary> The Id property of the Entity Category<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Category"."Id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)CategoryFieldIndex.Id, true); }
			set	{ SetValue((int)CategoryFieldIndex.Id, value, true); }
		}

		/// <summary> The Name property of the Entity Category<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Category"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)CategoryFieldIndex.Name, true); }
			set	{ SetValue((int)CategoryFieldIndex.Name, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'CategoryEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCategories()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ProductSearchEngine.CollectionClasses.CategoryCollection Categories
		{
			get	{ return GetMultiCategories(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Categories. When set to true, Categories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Categories is accessed. You can always execute/ a forced fetch by calling GetMultiCategories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCategories
		{
			get	{ return _alwaysFetchCategories; }
			set	{ _alwaysFetchCategories = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Categories already has been fetched. Setting this property to false when Categories has been fetched
		/// will clear the Categories collection well. Setting this property to true while Categories hasn't been fetched disables lazy loading for Categories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCategories
		{
			get { return _alreadyFetchedCategories;}
			set 
			{
				if(_alreadyFetchedCategories && !value && (_categories != null))
				{
					_categories.Clear();
				}
				_alreadyFetchedCategories = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProducts()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual ProductSearchEngine.CollectionClasses.ProductCollection Products
		{
			get	{ return GetMultiProducts(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Products. When set to true, Products is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Products is accessed. You can always execute/ a forced fetch by calling GetMultiProducts(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProducts
		{
			get	{ return _alwaysFetchProducts; }
			set	{ _alwaysFetchProducts = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Products already has been fetched. Setting this property to false when Products has been fetched
		/// will clear the Products collection well. Setting this property to true while Products hasn't been fetched disables lazy loading for Products</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProducts
		{
			get { return _alreadyFetchedProducts;}
			set 
			{
				if(_alreadyFetchedProducts && !value && (_products != null))
				{
					_products.Clear();
				}
				_alreadyFetchedProducts = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'CategoryEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCategory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CategoryEntity Category
		{
			get	{ return GetSingleCategory(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCategory(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Categories", "Category", _category, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Category. When set to true, Category is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Category is accessed. You can always execute a forced fetch by calling GetSingleCategory(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCategory
		{
			get	{ return _alwaysFetchCategory; }
			set	{ _alwaysFetchCategory = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Category already has been fetched. Setting this property to false when Category has been fetched
		/// will set Category to null as well. Setting this property to true while Category hasn't been fetched disables lazy loading for Category</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCategory
		{
			get { return _alreadyFetchedCategory;}
			set 
			{
				if(_alreadyFetchedCategory && !value)
				{
					this.Category = null;
				}
				_alreadyFetchedCategory = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Category is not found
		/// in the database. When set to true, Category will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool CategoryReturnsNewIfNotFound
		{
			get	{ return _categoryReturnsNewIfNotFound; }
			set { _categoryReturnsNewIfNotFound = value; }	
		}


		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary>Returns the ProductSearchEngine.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)ProductSearchEngine.EntityType.CategoryEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
