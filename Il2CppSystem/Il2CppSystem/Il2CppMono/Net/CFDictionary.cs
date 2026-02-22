using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppMono.Net
{
	// Token: 0x02000012 RID: 18
	public class CFDictionary : CFObject
	{
		// Token: 0x060000AF RID: 175 RVA: 0x00013540 File Offset: 0x00011740
		// Note: this type is marked as 'beforefieldinit'.
		static CFDictionary()
		{
			Il2CppClassPointerStore<CFDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net", "CFDictionary");
			CFDictionary.NativeFieldInfoPtr_KeyCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFDictionary>.NativeClassPtr, "KeyCallbacks");
			CFDictionary.NativeFieldInfoPtr_ValueCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFDictionary>.NativeClassPtr, "ValueCallbacks");
			CFDictionary.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFDictionary>.NativeClassPtr, 100663462);
			CFDictionary.NativeMethodInfoPtr_CFDictionaryGetValue_Private_Static_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFDictionary>.NativeClassPtr, 100663463);
			CFDictionary.NativeMethodInfoPtr_GetValue_Public_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFDictionary>.NativeClassPtr, 100663464);
			CFDictionary.NativeMethodInfoPtr_get_Item_Public_get_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFDictionary>.NativeClassPtr, 100663465);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000135E0 File Offset: 0x000117E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 32388, RefRangeEnd = 32390, XrefRangeStart = 32388, XrefRangeEnd = 32390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CFDictionary(IntPtr handle, bool own)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CFDictionary>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref own;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFDictionary.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00013638 File Offset: 0x00011838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32470, XrefRangeEnd = 32472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFDictionaryGetValue(IntPtr handle, IntPtr key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFDictionary.NativeMethodInfoPtr_CFDictionaryGetValue_Private_Static_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00013684 File Offset: 0x00011884
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 32477, RefRangeEnd = 32484, XrefRangeStart = 32472, XrefRangeEnd = 32477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetValue(IntPtr key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFDictionary.NativeMethodInfoPtr_GetValue_Public_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002E RID: 46
		public unsafe IntPtr this[IntPtr key]
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 32477, RefRangeEnd = 32484, XrefRangeStart = 32477, XrefRangeEnd = 32484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref key;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFDictionary.NativeMethodInfoPtr_get_Item_Public_get_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000240D File Offset: 0x0000060D
		public CFDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0001371C File Offset: 0x0001191C
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002416 File Offset: 0x00000616
		public unsafe static IntPtr KeyCallbacks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFDictionary.NativeFieldInfoPtr_KeyCallbacks, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFDictionary.NativeFieldInfoPtr_KeyCallbacks, (void*)(&value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00013738 File Offset: 0x00011938
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002424 File Offset: 0x00000624
		public unsafe static IntPtr ValueCallbacks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFDictionary.NativeFieldInfoPtr_ValueCallbacks, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFDictionary.NativeFieldInfoPtr_ValueCallbacks, (void*)(&value));
			}
		}

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_KeyCallbacks;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_ValueCallbacks;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_CFDictionaryGetValue_Private_Static_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_IntPtr_IntPtr_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_IntPtr_IntPtr_0;
	}
}
