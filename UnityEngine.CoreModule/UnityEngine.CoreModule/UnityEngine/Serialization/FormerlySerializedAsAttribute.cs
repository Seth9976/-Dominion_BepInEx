using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Serialization
{
	// Token: 0x02000111 RID: 273
	public class FormerlySerializedAsAttribute : Attribute
	{
		// Token: 0x0600165C RID: 5724 RVA: 0x000553F4 File Offset: 0x000535F4
		// Note: this type is marked as 'beforefieldinit'.
		static FormerlySerializedAsAttribute()
		{
			Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Serialization", "FormerlySerializedAsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr);
			FormerlySerializedAsAttribute.NativeFieldInfoPtr_m_oldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr, "m_oldName");
			FormerlySerializedAsAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr, 100664970);
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0005544C File Offset: 0x0005364C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormerlySerializedAsAttribute(string oldName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormerlySerializedAsAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x0000C9B4 File Offset: 0x0000ABB4
		public FormerlySerializedAsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x00055498 File Offset: 0x00053698
		// (set) Token: 0x06001660 RID: 5728 RVA: 0x0000C9BD File Offset: 0x0000ABBD
		public unsafe string m_oldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormerlySerializedAsAttribute.NativeFieldInfoPtr_m_oldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormerlySerializedAsAttribute.NativeFieldInfoPtr_m_oldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x000554C0 File Offset: 0x000536C0
		public string oldName
		{
			get
			{
				return this.m_oldName;
			}
		}

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeFieldInfoPtr_m_oldName;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
