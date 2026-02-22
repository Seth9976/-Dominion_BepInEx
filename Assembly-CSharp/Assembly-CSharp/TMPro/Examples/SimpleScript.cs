using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000105 RID: 261
	public class SimpleScript : MonoBehaviour
	{
		// Token: 0x06001EF7 RID: 7927 RVA: 0x00078948 File Offset: 0x00076B48
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleScript()
		{
			Il2CppClassPointerStore<SimpleScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "SimpleScript");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleScript>.NativeClassPtr);
			SimpleScript.NativeFieldInfoPtr_m_textMeshPro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleScript>.NativeClassPtr, "m_textMeshPro");
			SimpleScript.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleScript>.NativeClassPtr, "label");
			SimpleScript.NativeFieldInfoPtr_m_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleScript>.NativeClassPtr, "m_frame");
			SimpleScript.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleScript>.NativeClassPtr, 100665830);
			SimpleScript.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleScript>.NativeClassPtr, 100665831);
			SimpleScript.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleScript>.NativeClassPtr, 100665832);
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x000789F0 File Offset: 0x00076BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256006, XrefRangeEnd = 256014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleScript.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00078A24 File Offset: 0x00076C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256014, XrefRangeEnd = 256019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleScript.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x00078A58 File Offset: 0x00076C58
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleScript()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleScript>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleScript.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x00013563 File Offset: 0x00011763
		public SimpleScript(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001EFC RID: 7932 RVA: 0x00078A94 File Offset: 0x00076C94
		// (set) Token: 0x06001EFD RID: 7933 RVA: 0x0001356C File Offset: 0x0001176C
		public unsafe TextMeshPro m_textMeshPro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleScript.NativeFieldInfoPtr_m_textMeshPro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleScript.NativeFieldInfoPtr_m_textMeshPro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001EFE RID: 7934 RVA: 0x00078AC4 File Offset: 0x00076CC4
		// (set) Token: 0x06001EFF RID: 7935 RVA: 0x0001358B File Offset: 0x0001178B
		public unsafe static string label
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SimpleScript.NativeFieldInfoPtr_label, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SimpleScript.NativeFieldInfoPtr_label, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x00078AE4 File Offset: 0x00076CE4
		// (set) Token: 0x06001F01 RID: 7937 RVA: 0x0001359D File Offset: 0x0001179D
		public unsafe float m_frame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleScript.NativeFieldInfoPtr_m_frame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleScript.NativeFieldInfoPtr_m_frame)) = value;
			}
		}

		// Token: 0x040014EC RID: 5356
		private static readonly IntPtr NativeFieldInfoPtr_m_textMeshPro;

		// Token: 0x040014ED RID: 5357
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x040014EE RID: 5358
		private static readonly IntPtr NativeFieldInfoPtr_m_frame;

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
