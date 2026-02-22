using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020000E9 RID: 233
	public class StylePropertyValueMatcher : BaseStyleMatcher
	{
		// Token: 0x06000D0A RID: 3338 RVA: 0x00033BC4 File Offset: 0x00031DC4
		// Note: this type is marked as 'beforefieldinit'.
		static StylePropertyValueMatcher()
		{
			Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "StylePropertyValueMatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr);
			StylePropertyValueMatcher.NativeFieldInfoPtr_m_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, "m_Values");
			StylePropertyValueMatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr, 100664285);
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00033C1C File Offset: 0x00031E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97346, XrefRangeEnd = 97347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StylePropertyValueMatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyValueMatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyValueMatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00008434 File Offset: 0x00006634
		public StylePropertyValueMatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x00033C58 File Offset: 0x00031E58
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x0000843D File Offset: 0x0000663D
		public unsafe List<StylePropertyValue> m_Values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyValueMatcher.NativeFieldInfoPtr_m_Values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StylePropertyValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyValueMatcher.NativeFieldInfoPtr_m_Values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00033C88 File Offset: 0x00031E88
		public StylePropertyValue current
		{
			get
			{
				return base.hasCurrent ? this.m_Values[base.m_CurrentIndex] : null;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x0000845C File Offset: 0x0000665C
		public override int valueCount
		{
			get
			{
				return this.m_Values.Count;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x00008469 File Offset: 0x00006669
		public override bool isVariable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x0000846C File Offset: 0x0000666C
		public override bool MatchKeyword(string keyword)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00008479 File Offset: 0x00006679
		public override bool MatchNumber()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00008486 File Offset: 0x00006686
		public override bool MatchInteger()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00008493 File Offset: 0x00006693
		public override bool MatchLength()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x000084A0 File Offset: 0x000066A0
		public override bool MatchPercentage()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x000084AD File Offset: 0x000066AD
		public override bool MatchColor()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x000084BA File Offset: 0x000066BA
		public override bool MatchResource()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x000084C7 File Offset: 0x000066C7
		public override bool MatchUrl()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeFieldInfoPtr_m_Values;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
