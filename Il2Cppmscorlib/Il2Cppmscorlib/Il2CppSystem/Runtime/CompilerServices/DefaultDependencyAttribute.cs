using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000427 RID: 1063
	[Serializable]
	public sealed class DefaultDependencyAttribute : Attribute
	{
		// Token: 0x0600421C RID: 16924 RVA: 0x00130C88 File Offset: 0x0012EE88
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultDependencyAttribute()
		{
			Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "DefaultDependencyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr);
			DefaultDependencyAttribute.NativeFieldInfoPtr_loadHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr, "loadHint");
			DefaultDependencyAttribute.NativeMethodInfoPtr__ctor_Public_Void_LoadHint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr, 100672919);
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x00130CE0 File Offset: 0x0012EEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultDependencyAttribute(LoadHint loadHintArgument)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref loadHintArgument;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultDependencyAttribute.NativeMethodInfoPtr__ctor_Public_Void_LoadHint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600421E RID: 16926 RVA: 0x0001935A File Offset: 0x0001755A
		public DefaultDependencyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x0600421F RID: 16927 RVA: 0x00130D28 File Offset: 0x0012EF28
		// (set) Token: 0x06004220 RID: 16928 RVA: 0x00019363 File Offset: 0x00017563
		public unsafe LoadHint loadHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDependencyAttribute.NativeFieldInfoPtr_loadHint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDependencyAttribute.NativeFieldInfoPtr_loadHint)) = value;
			}
		}

		// Token: 0x040035D6 RID: 13782
		private static readonly IntPtr NativeFieldInfoPtr_loadHint;

		// Token: 0x040035D7 RID: 13783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LoadHint_0;
	}
}
