using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UTNotifications
{
	// Token: 0x020000EF RID: 239
	public sealed class JsonUtils : Object
	{
		// Token: 0x06001CD9 RID: 7385 RVA: 0x00070D80 File Offset: 0x0006EF80
		// Note: this type is marked as 'beforefieldinit'.
		static JsonUtils()
		{
			Il2CppClassPointerStore<JsonUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "JsonUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonUtils>.NativeClassPtr);
			JsonUtils.NativeMethodInfoPtr_ToJson_Public_Static_JSONArray_ICollection_1_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtils>.NativeClassPtr, 100665585);
			JsonUtils.NativeMethodInfoPtr_ToJson_Public_Static_JSONNode_IDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtils>.NativeClassPtr, 100665586);
			JsonUtils.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtils>.NativeClassPtr, 100665587);
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00070DEC File Offset: 0x0006EFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254276, XrefRangeEnd = 254319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JSONArray ToJson(ICollection<Button> buttons)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buttons);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonUtils.NativeMethodInfoPtr_ToJson_Public_Static_JSONArray_ICollection_1_Button_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONArray>(intPtr3) : null;
			}
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x00070E30 File Offset: 0x0006F030
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254347, RefRangeEnd = 254349, XrefRangeStart = 254319, XrefRangeEnd = 254347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JSONNode ToJson(IDictionary<string, string> userData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(userData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonUtils.NativeMethodInfoPtr_ToJson_Public_Static_JSONNode_IDictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x00070E74 File Offset: 0x0006F074
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonUtils()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonUtils>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonUtils.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x0001268F File Offset: 0x0001088F
		public JsonUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeMethodInfoPtr_ToJson_Public_Static_JSONArray_ICollection_1_Button_0;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr_ToJson_Public_Static_JSONNode_IDictionary_2_String_String_0;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
