using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004B7 RID: 1207
	public sealed class DebuggableAttribute : Attribute
	{
		// Token: 0x06004735 RID: 18229 RVA: 0x00147888 File Offset: 0x00145A88
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggableAttribute()
		{
			Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr);
			DebuggableAttribute.NativeFieldInfoPtr_m_debuggingModes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr, "m_debuggingModes");
			DebuggableAttribute.NativeMethodInfoPtr__ctor_Public_Void_DebuggingModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr, 100673870);
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x001478E0 File Offset: 0x00145AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggableAttribute(DebuggableAttribute.DebuggingModes modes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggableAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref modes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggableAttribute.NativeMethodInfoPtr__ctor_Public_Void_DebuggingModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x0001AE05 File Offset: 0x00019005
		public DebuggableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x06004738 RID: 18232 RVA: 0x00147928 File Offset: 0x00145B28
		// (set) Token: 0x06004739 RID: 18233 RVA: 0x0001AE0E File Offset: 0x0001900E
		public unsafe DebuggableAttribute.DebuggingModes m_debuggingModes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggableAttribute.NativeFieldInfoPtr_m_debuggingModes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggableAttribute.NativeFieldInfoPtr_m_debuggingModes)) = value;
			}
		}

		// Token: 0x040039BF RID: 14783
		private static readonly IntPtr NativeFieldInfoPtr_m_debuggingModes;

		// Token: 0x040039C0 RID: 14784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DebuggingModes_0;

		// Token: 0x0200066A RID: 1642
		[Flags]
		public enum DebuggingModes
		{
			// Token: 0x0400454C RID: 17740
			None = 0,
			// Token: 0x0400454D RID: 17741
			Default = 1,
			// Token: 0x0400454E RID: 17742
			DisableOptimizations = 256,
			// Token: 0x0400454F RID: 17743
			IgnoreSymbolStoreSequencePoints = 2,
			// Token: 0x04004550 RID: 17744
			EnableEditAndContinue = 4
		}
	}
}
