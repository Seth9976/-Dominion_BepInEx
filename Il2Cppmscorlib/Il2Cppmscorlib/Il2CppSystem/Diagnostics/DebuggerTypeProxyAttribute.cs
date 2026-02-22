using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004BA RID: 1210
	public sealed class DebuggerTypeProxyAttribute : Attribute
	{
		// Token: 0x0600473F RID: 18239 RVA: 0x00147A18 File Offset: 0x00145C18
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerTypeProxyAttribute()
		{
			Il2CppClassPointerStore<DebuggerTypeProxyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerTypeProxyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerTypeProxyAttribute>.NativeClassPtr);
			DebuggerTypeProxyAttribute.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerTypeProxyAttribute>.NativeClassPtr, "typeName");
			DebuggerTypeProxyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerTypeProxyAttribute>.NativeClassPtr, 100673872);
		}

		// Token: 0x06004740 RID: 18240 RVA: 0x00147A70 File Offset: 0x00145C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365688, XrefRangeEnd = 365693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggerTypeProxyAttribute(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerTypeProxyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerTypeProxyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004741 RID: 18241 RVA: 0x0001AE4D File Offset: 0x0001904D
		public DebuggerTypeProxyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x06004742 RID: 18242 RVA: 0x00147ABC File Offset: 0x00145CBC
		// (set) Token: 0x06004743 RID: 18243 RVA: 0x0001AE56 File Offset: 0x00019056
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerTypeProxyAttribute.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerTypeProxyAttribute.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040039C7 RID: 14791
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x040039C8 RID: 14792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
