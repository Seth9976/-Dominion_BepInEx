using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000CC RID: 204
	public sealed class DtdValidator : BaseValidator
	{
		// Token: 0x06000C9A RID: 3226 RVA: 0x0003CC88 File Offset: 0x0003AE88
		// Note: this type is marked as 'beforefieldinit'.
		static DtdValidator()
		{
			Il2CppClassPointerStore<DtdValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "DtdValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr);
			DtdValidator.NativeFieldInfoPtr_namespaceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, "namespaceManager");
			DtdValidator.NativeMethodInfoPtr_SetDefaultTypedValue_Public_Static_Void_SchemaAttDef_IDtdParserAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, 100665152);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x0003CCE0 File Offset: 0x0003AEE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23567, RefRangeEnd = 23568, XrefRangeStart = 23544, XrefRangeEnd = 23567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attdef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(readerAdapter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NativeMethodInfoPtr_SetDefaultTypedValue_Public_Static_Void_SchemaAttDef_IDtdParserAdapter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x0000629C File Offset: 0x0000449C
		public DtdValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x0003CD28 File Offset: 0x0003AF28
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x000062A5 File Offset: 0x000044A5
		public unsafe static DtdValidator.NamespaceManager namespaceManager
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DtdValidator.NativeFieldInfoPtr_namespaceManager, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DtdValidator.NamespaceManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DtdValidator.NativeFieldInfoPtr_namespaceManager, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeFieldInfoPtr_namespaceManager;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultTypedValue_Public_Static_Void_SchemaAttDef_IDtdParserAdapter_0;

		// Token: 0x02000130 RID: 304
		public class NamespaceManager : XmlNamespaceManager
		{
			// Token: 0x060012C5 RID: 4805 RVA: 0x00055A9C File Offset: 0x00053C9C
			// Note: this type is marked as 'beforefieldinit'.
			static NamespaceManager()
			{
				Il2CppClassPointerStore<DtdValidator.NamespaceManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DtdValidator>.NativeClassPtr, "NamespaceManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DtdValidator.NamespaceManager>.NativeClassPtr);
				DtdValidator.NamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator.NamespaceManager>.NativeClassPtr, 100665154);
				DtdValidator.NamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdValidator.NamespaceManager>.NativeClassPtr, 100665155);
			}

			// Token: 0x060012C6 RID: 4806 RVA: 0x00055AF0 File Offset: 0x00053CF0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23543, RefRangeEnd = 23544, XrefRangeStart = 23543, XrefRangeEnd = 23543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string LookupNamespace(string prefix)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DtdValidator.NamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060012C7 RID: 4807 RVA: 0x00055B44 File Offset: 0x00053D44
			[CallerCount(114)]
			[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NamespaceManager()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DtdValidator.NamespaceManager>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdValidator.NamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060012C8 RID: 4808 RVA: 0x000086BF File Offset: 0x000068BF
			public NamespaceManager(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000EBA RID: 3770
			private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0;

			// Token: 0x04000EBB RID: 3771
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
