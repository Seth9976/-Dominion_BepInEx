using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000101 RID: 257
	public class Benchmark04 : MonoBehaviour
	{
		// Token: 0x06001E89 RID: 7817 RVA: 0x000779EC File Offset: 0x00075BEC
		// Note: this type is marked as 'beforefieldinit'.
		static Benchmark04()
		{
			Il2CppClassPointerStore<Benchmark04>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "Benchmark04");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Benchmark04>.NativeClassPtr);
			Benchmark04.NativeFieldInfoPtr_SpawnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark04>.NativeClassPtr, "SpawnType");
			Benchmark04.NativeFieldInfoPtr_MinPointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark04>.NativeClassPtr, "MinPointSize");
			Benchmark04.NativeFieldInfoPtr_MaxPointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark04>.NativeClassPtr, "MaxPointSize");
			Benchmark04.NativeFieldInfoPtr_Steps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark04>.NativeClassPtr, "Steps");
			Benchmark04.NativeFieldInfoPtr_m_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benchmark04>.NativeClassPtr, "m_Transform");
			Benchmark04.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark04>.NativeClassPtr, 100665816);
			Benchmark04.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benchmark04>.NativeClassPtr, 100665817);
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x00077AA8 File Offset: 0x00075CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255806, XrefRangeEnd = 255840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark04.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x00077ADC File Offset: 0x00075CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255840, XrefRangeEnd = 255841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Benchmark04()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Benchmark04>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benchmark04.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x0001308D File Offset: 0x0001128D
		public Benchmark04(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x00077B18 File Offset: 0x00075D18
		// (set) Token: 0x06001E8E RID: 7822 RVA: 0x00013096 File Offset: 0x00011296
		public unsafe int SpawnType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark04.NativeFieldInfoPtr_SpawnType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark04.NativeFieldInfoPtr_SpawnType)) = value;
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x00077B40 File Offset: 0x00075D40
		// (set) Token: 0x06001E90 RID: 7824 RVA: 0x000130B1 File Offset: 0x000112B1
		public unsafe int MinPointSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark04.NativeFieldInfoPtr_MinPointSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark04.NativeFieldInfoPtr_MinPointSize)) = value;
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x00077B68 File Offset: 0x00075D68
		// (set) Token: 0x06001E92 RID: 7826 RVA: 0x000130CC File Offset: 0x000112CC
		public unsafe int MaxPointSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark04.NativeFieldInfoPtr_MaxPointSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark04.NativeFieldInfoPtr_MaxPointSize)) = value;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x00077B90 File Offset: 0x00075D90
		// (set) Token: 0x06001E94 RID: 7828 RVA: 0x000130E7 File Offset: 0x000112E7
		public unsafe int Steps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark04.NativeFieldInfoPtr_Steps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark04.NativeFieldInfoPtr_Steps)) = value;
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06001E95 RID: 7829 RVA: 0x00077BB8 File Offset: 0x00075DB8
		// (set) Token: 0x06001E96 RID: 7830 RVA: 0x00013102 File Offset: 0x00011302
		public unsafe Transform m_Transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark04.NativeFieldInfoPtr_m_Transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benchmark04.NativeFieldInfoPtr_m_Transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeFieldInfoPtr_SpawnType;

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeFieldInfoPtr_MinPointSize;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeFieldInfoPtr_MaxPointSize;

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeFieldInfoPtr_Steps;

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeFieldInfoPtr_m_Transform;

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
