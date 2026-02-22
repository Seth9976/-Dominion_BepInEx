using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004BB RID: 1211
	public sealed class DebuggerDisplayAttribute : Attribute
	{
		// Token: 0x06004744 RID: 18244 RVA: 0x00147AE4 File Offset: 0x00145CE4
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerDisplayAttribute()
		{
			Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerDisplayAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr);
			DebuggerDisplayAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr, "name");
			DebuggerDisplayAttribute.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr, "value");
			DebuggerDisplayAttribute.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr, "type");
			DebuggerDisplayAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr, 100673873);
		}

		// Token: 0x06004745 RID: 18245 RVA: 0x00147B64 File Offset: 0x00145D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365693, XrefRangeEnd = 365698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggerDisplayAttribute(string value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerDisplayAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004746 RID: 18246 RVA: 0x0001AE75 File Offset: 0x00019075
		public DebuggerDisplayAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x06004747 RID: 18247 RVA: 0x00147BB0 File Offset: 0x00145DB0
		// (set) Token: 0x06004748 RID: 18248 RVA: 0x0001AE7E File Offset: 0x0001907E
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerDisplayAttribute.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerDisplayAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x06004749 RID: 18249 RVA: 0x00147BD8 File Offset: 0x00145DD8
		// (set) Token: 0x0600474A RID: 18250 RVA: 0x0001AE9D File Offset: 0x0001909D
		public unsafe string value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerDisplayAttribute.NativeFieldInfoPtr_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerDisplayAttribute.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x0600474B RID: 18251 RVA: 0x00147C00 File Offset: 0x00145E00
		// (set) Token: 0x0600474C RID: 18252 RVA: 0x0001AEBC File Offset: 0x000190BC
		public unsafe string type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerDisplayAttribute.NativeFieldInfoPtr_type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerDisplayAttribute.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040039C9 RID: 14793
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040039CA RID: 14794
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040039CB RID: 14795
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040039CC RID: 14796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
