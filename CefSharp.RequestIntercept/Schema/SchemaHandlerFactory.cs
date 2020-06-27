using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using CefSharp.RequestIntercept.Debug;
using CefSharp.RequestIntercept.Util;

namespace CefSharp.RequestIntercept.Schema
{
    public class SchemaHandlerFactory
    {
        public const string SchemaNameKey = "schema";

        private Dictionary<string, Type> _cachedSchemaHandlerTypes;

        private Dictionary<string, SchemaHandlerMetaAttribute> _schemaHandlerMetaAttributes;

        public void Load()
        {
            _cachedSchemaHandlerTypes = (_cachedSchemaHandlerTypes ?? new Dictionary<string, Type>());
            _cachedSchemaHandlerTypes.Clear();
            _schemaHandlerMetaAttributes = (_schemaHandlerMetaAttributes ?? new Dictionary<string, SchemaHandlerMetaAttribute>());
            _schemaHandlerMetaAttributes.Clear();

            Assembly assembly = Assembly.GetExecutingAssembly();
            assembly.GetTypes().ToList().ForEach(type =>
            {
                if (!typeof(SchemaHandler).IsAssignableFrom(type) || type.IsAbstract)
                {
                    return;
                }
                SchemaHandlerMetaAttribute schemaHandlerMetaAttribute = ReflectionUtil.GetAttribute<SchemaHandlerMetaAttribute>(type);
                if (schemaHandlerMetaAttribute == null)
                {
                    return;
                }
                string name = schemaHandlerMetaAttribute.Name.ToLower();
                _cachedSchemaHandlerTypes.Add(name, type);
                _schemaHandlerMetaAttributes.Add(name, schemaHandlerMetaAttribute);
            });
        }

        public SchemaHandler GetSchemaHandler(NameValueCollection query)
        {
            string schemaName = query[SchemaNameKey];
            if (string.IsNullOrWhiteSpace(schemaName))
            {
                throw new Exception("Schema name should not be EMPTY!");
            }

            if (!this._cachedSchemaHandlerTypes.TryGetValue(schemaName, out Type schemaHandlerType))
            {
                throw new Exception("Cannot find the SchemaHandler named " + schemaName);
            }

            if (!this._schemaHandlerMetaAttributes.TryGetValue(schemaName, out SchemaHandlerMetaAttribute metaAttribute))
            {
                throw new Exception("Cannot find the SchemaHandlerMeta which SchemaName is " + schemaName);
            }

            try
            {
                SchemaHandler schemaHandler = (SchemaHandler) Activator.CreateInstance(schemaHandlerType);
                schemaHandler.SchemaHandlerMeta = metaAttribute;
                SchemaDebugHandler.Attach(schemaHandler);
                return schemaHandler; 
            }
            catch (Exception e)
            {
                throw new Exception("Cannot create a instance which Type is SchemaHandler");
            }
        }
        
    }
}