using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000430 RID: 1072
	public sealed class InternalsVisibleToAttribute : Attribute
	{
		// Token: 0x06004246 RID: 16966 RVA: 0x001313F0 File Offset: 0x0012F5F0
		// Note: this type is marked as 'beforefieldinit'.
		static InternalsVisibleToAttribute()
		{
			Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "InternalsVisibleToAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr);
			InternalsVisibleToAttribute.NativeFieldInfoPtr__assemblyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, "_assemblyName");
			InternalsVisibleToAttribute.NativeFieldInfoPtr__allInternalsVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, "_allInternalsVisible");
			InternalsVisibleToAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, 100672933);
			InternalsVisibleToAttribute.NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, 100672934);
			InternalsVisibleToAttribute.NativeMethodInfoPtr_get_AllInternalsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, 100672935);
			InternalsVisibleToAttribute.NativeMethodInfoPtr_set_AllInternalsVisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, 100672936);
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x00131498 File Offset: 0x0012F698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357109, XrefRangeEnd = 357110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalsVisibleToAttribute(string assemblyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalsVisibleToAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x06004248 RID: 16968 RVA: 0x001314E4 File Offset: 0x0012F6E4
		public unsafe string AssemblyName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalsVisibleToAttribute.NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x06004249 RID: 16969 RVA: 0x0013151C File Offset: 0x0012F71C
		// (set) Token: 0x0600424A RID: 16970 RVA: 0x00131558 File Offset: 0x0012F758
		public unsafe bool AllInternalsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalsVisibleToAttribute.NativeMethodInfoPtr_get_AllInternalsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalsVisibleToAttribute.NativeMethodInfoPtr_set_AllInternalsVisible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x000194BA File Offset: 0x000176BA
		public InternalsVisibleToAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x0600424C RID: 16972 RVA: 0x00131598 File Offset: 0x0012F798
		// (set) Token: 0x0600424D RID: 16973 RVA: 0x000194C3 File Offset: 0x000176C3
		public unsafe string _assemblyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalsVisibleToAttribute.NativeFieldInfoPtr__assemblyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalsVisibleToAttribute.NativeFieldInfoPtr__assemblyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x0600424E RID: 16974 RVA: 0x001315C0 File Offset: 0x0012F7C0
		// (set) Token: 0x0600424F RID: 16975 RVA: 0x000194E2 File Offset: 0x000176E2
		public unsafe bool _allInternalsVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalsVisibleToAttribute.NativeFieldInfoPtr__allInternalsVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalsVisibleToAttribute.NativeFieldInfoPtr__allInternalsVisible)) = value;
			}
		}

		// Token: 0x040035EC RID: 13804
		private static readonly IntPtr NativeFieldInfoPtr__assemblyName;

		// Token: 0x040035ED RID: 13805
		private static readonly IntPtr NativeFieldInfoPtr__allInternalsVisible;

		// Token: 0x040035EE RID: 13806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040035EF RID: 13807
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0;

		// Token: 0x040035F0 RID: 13808
		private static readonly IntPtr NativeMethodInfoPtr_get_AllInternalsVisible_Public_get_Boolean_0;

		// Token: 0x040035F1 RID: 13809
		private static readonly IntPtr NativeMethodInfoPtr_set_AllInternalsVisible_Public_set_Void_Boolean_0;
	}
}
