using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004B9 RID: 1209
	public sealed class DebuggerBrowsableAttribute : Attribute
	{
		// Token: 0x0600473A RID: 18234 RVA: 0x00147950 File Offset: 0x00145B50
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerBrowsableAttribute()
		{
			Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerBrowsableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr);
			DebuggerBrowsableAttribute.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr, "state");
			DebuggerBrowsableAttribute.NativeMethodInfoPtr__ctor_Public_Void_DebuggerBrowsableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr, 100673871);
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x001479A8 File Offset: 0x00145BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365687, XrefRangeEnd = 365688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggerBrowsableAttribute(DebuggerBrowsableState state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerBrowsableAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerBrowsableAttribute.NativeMethodInfoPtr__ctor_Public_Void_DebuggerBrowsableState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600473C RID: 18236 RVA: 0x0001AE29 File Offset: 0x00019029
		public DebuggerBrowsableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x0600473D RID: 18237 RVA: 0x001479F0 File Offset: 0x00145BF0
		// (set) Token: 0x0600473E RID: 18238 RVA: 0x0001AE32 File Offset: 0x00019032
		public unsafe DebuggerBrowsableState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerBrowsableAttribute.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerBrowsableAttribute.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x040039C5 RID: 14789
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040039C6 RID: 14790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DebuggerBrowsableState_0;
	}
}
