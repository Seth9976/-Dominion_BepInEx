using System;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;
using UnityEngine.UIElements.Experimental;

namespace UnityEngine.UIElements
{
	// Token: 0x02000128 RID: 296
	public class VisualElementAnimationSystem : BaseVisualTreeUpdater
	{
		// Token: 0x06000E13 RID: 3603 RVA: 0x00035818 File Offset: 0x00033A18
		public long CurrentTimeMs()
		{
			return Panel.TimeSinceStartupMs();
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x00008EC4 File Offset: 0x000070C4
		public override ProfilerMarker profilerMarker
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00008ED1 File Offset: 0x000070D1
		public void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00008EDE File Offset: 0x000070DE
		public void UnregisterAnimations(List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00008EEB File Offset: 0x000070EB
		public void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00008EF8 File Offset: 0x000070F8
		public void RegisterAnimations(List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00008F05 File Offset: 0x00007105
		public override void Update()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00008F12 File Offset: 0x00007112
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}
	}
}
