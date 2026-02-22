using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000017 RID: 23
	public class GUITargetAttribute : Attribute
	{
		// Token: 0x0600040D RID: 1037 RVA: 0x000102B8 File Offset: 0x0000E4B8
		// Note: this type is marked as 'beforefieldinit'.
		static GUITargetAttribute()
		{
			Il2CppClassPointerStore<GUITargetAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUITargetAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUITargetAttribute>.NativeClassPtr);
			GUITargetAttribute.NativeFieldInfoPtr_displayMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUITargetAttribute>.NativeClassPtr, "displayMask");
			GUITargetAttribute.NativeMethodInfoPtr_GetGUITargetAttrValue_Private_Static_Int32_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUITargetAttribute>.NativeClassPtr, 100663606);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00010310 File Offset: 0x0000E510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87322, XrefRangeEnd = 87333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGUITargetAttrValue(Type klass, string methodName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(klass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUITargetAttribute.NativeMethodInfoPtr_GetGUITargetAttrValue_Private_Static_Int32_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00003B93 File Offset: 0x00001D93
		public GUITargetAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00010364 File Offset: 0x0000E564
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00003B9C File Offset: 0x00001D9C
		public unsafe int displayMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUITargetAttribute.NativeFieldInfoPtr_displayMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUITargetAttribute.NativeFieldInfoPtr_displayMask)) = value;
			}
		}

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeFieldInfoPtr_displayMask;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_GetGUITargetAttrValue_Private_Static_Int32_Type_String_0;
	}
}
